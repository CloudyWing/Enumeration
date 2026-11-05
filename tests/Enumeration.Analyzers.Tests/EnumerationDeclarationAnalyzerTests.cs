using System.Collections.Immutable;
using CloudyWing.Enumeration.Abstractions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CloudyWing.Enumeration.Analyzers.Tests {
    internal class EnumerationDeclarationAnalyzerTests {
        private const string Usings = """
            using CloudyWing.Enumeration;
            using CloudyWing.Enumeration.Abstractions;

            """;

        [Test]
        public async Task Analyze_UniqueMembersWithPrivateConstructor_ReportsNothing() {
            string source = Usings + """
                public sealed class Color : EnumerationBase<Color, int> {
                    private Color(int value, string name) : base(value, name) { }

                    public static Color Red { get; } = new Color(1, "Red");

                    public static Color Green { get; } = new(2, "Green");

                    public static Color Default => Red;
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public async Task Analyze_DuplicateValue_ReportsEnum001() {
            string source = Usings + """
                public sealed class Color : EnumerationBase<Color, int> {
                    private Color(int value, string name) : base(value, name) { }

                    public static Color Red { get; } = new Color(1, "Red");

                    public static Color Crimson { get; } = new Color(1, "Crimson");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual.Select(x => x.Id), Is.EqualTo(new[] { EnumerationDeclarationAnalyzer.DuplicateValueId }).AsCollection);
        }

        [Test]
        public async Task Analyze_DuplicateName_ReportsEnum002() {
            string source = Usings + """
                public sealed class Color : EnumerationBase<Color, int> {
                    private Color(int value, string name) : base(value, name) { }

                    public static Color Red { get; } = new Color(1, "Red");

                    public static Color Crimson => new Color(2, "Red");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual.Select(x => x.Id), Is.EqualTo(new[] { EnumerationDeclarationAnalyzer.DuplicateNameId }).AsCollection);
        }

        [Test]
        public async Task Analyze_ConstructorChainWithExtraParameters_ResolvesValueAndName() {
            string source = Usings + """
                public sealed class Month : IntEnumeration<Month> {
                    private Month(int number, string displayName, string englishName) : this(englishName, number, displayName) { }

                    private Month(string englishName, int number, string displayName) : base(number, displayName) {
                        EnglishName = englishName;
                    }

                    public string EnglishName { get; }

                    public static Month January { get; } = new Month(1, "一月", "January");

                    public static Month Duplicate { get; } = new Month(1, "一月", "Duplicate");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(
                actual.Select(x => x.Id).OrderBy(x => x),
                Is.EqualTo(new[] { EnumerationDeclarationAnalyzer.DuplicateValueId, EnumerationDeclarationAnalyzer.DuplicateNameId }.OrderBy(x => x)).AsCollection
            );
        }

        [Test]
        public async Task Analyze_ValueOnlyConstructor_ReportsDuplicateValueAndName() {
            string source = Usings + """
                public sealed class Code : EnumerationBase<Code, string> {
                    private Code(string value) : base(value) { }

                    public static Code A { get; } = new Code("A");

                    public static Code B { get; } = new Code("A");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual, Has.Length.EqualTo(2));
        }

        [Test]
        public async Task Analyze_IgnoredDuplicateMember_ReportsNothing() {
            string source = Usings + """
                public sealed class Color : EnumerationBase<Color, int> {
                    private Color(int value, string name) : base(value, name) { }

                    public static Color Red { get; } = new Color(1, "Red");

                    [EnumerationIgnore]
                    public static Color Helper { get; } = new Color(1, "Red");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public async Task Analyze_PublicConstructorOnConcreteType_ReportsEnum003() {
            string source = Usings + """
                public sealed class Color : EnumerationBase<Color, int> {
                    public Color(int value, string name) : base(value, name) { }

                    public static Color Red { get; } = new Color(1, "Red");
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual.Select(x => x.Id), Is.EqualTo(new[] { EnumerationDeclarationAnalyzer.PublicConstructorId }).AsCollection);
        }

        [Test]
        public async Task Analyze_PublicConstructorOnAbstractType_ReportsNothing() {
            string source = Usings + """
                public abstract class StatusBase<T> : EnumerationBase<T, int> where T : StatusBase<T> {
                    public StatusBase(int value, string name) : base(value, name) { }
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public async Task Analyze_NonEnumerationType_ReportsNothing() {
            string source = """
                public sealed class Color {
                    public Color(int value) { }

                    public static Color Red { get; } = new Color(1);

                    public static Color Crimson { get; } = new Color(1);
                }
                """;

            ImmutableArray<Diagnostic> actual = await AnalyzeAsync(source);

            Assert.That(actual, Is.Empty);
        }

        private static async Task<ImmutableArray<Diagnostic>> AnalyzeAsync(string source) {
            string trustedAssemblies = (string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!;
            IEnumerable<MetadataReference> references = trustedAssemblies
                .Split(Path.PathSeparator)
                .Select(x => MetadataReference.CreateFromFile(x))
                .Append(MetadataReference.CreateFromFile(typeof(EnumerationBase<,>).Assembly.Location));
            CSharpCompilation compilation = CSharpCompilation.Create(
                "AnalyzerTarget",
                [CSharpSyntaxTree.ParseText(source)],
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
            );

            ImmutableArray<Diagnostic> compilerErrors = compilation.GetDiagnostics()
                .Where(x => x.Severity == DiagnosticSeverity.Error)
                .ToImmutableArray();
            Assert.That(compilerErrors, Is.Empty, "The analyzed source must compile.");

            CompilationWithAnalyzers analyzed = compilation.WithAnalyzers([new EnumerationDeclarationAnalyzer()]);
            return await analyzed.GetAnalyzerDiagnosticsAsync().ConfigureAwait(false);
        }
    }
}
