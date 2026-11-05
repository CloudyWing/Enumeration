using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace CloudyWing.Enumeration.Analyzers {
    /// <summary>
    /// Reports duplicate values, duplicate names and public constructors on types derived from <c>EnumerationBase&lt;TEnum, TValue&gt;</c>.
    /// </summary>
    /// <remarks>
    /// Values and names are checked for members declared as public static properties whose initializer or expression body creates the
    /// enumeration with constant arguments. Members created in other ways, such as through <c>Lazy&lt;T&gt;</c> fields, are not checked.
    /// </remarks>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class EnumerationDeclarationAnalyzer : DiagnosticAnalyzer {
        /// <summary>
        /// The diagnostic ID reported when two members declare the same value.
        /// </summary>
        public const string DuplicateValueId = "ENUM001";

        /// <summary>
        /// The diagnostic ID reported when two members declare the same name.
        /// </summary>
        public const string DuplicateNameId = "ENUM002";

        /// <summary>
        /// The diagnostic ID reported when a concrete enumeration declares a public constructor.
        /// </summary>
        public const string PublicConstructorId = "ENUM003";

        private const string Category = "Design";
        private const string EnumerationBaseMetadataName = "CloudyWing.Enumeration.Abstractions.EnumerationBase`2";
        private const string IgnoreAttributeMetadataName = "CloudyWing.Enumeration.EnumerationIgnoreAttribute";
        private const string ValueParameterName = "value";
        private const string NameParameterName = "name";

        private static readonly DiagnosticDescriptor DuplicateValueRule = new DiagnosticDescriptor(
            DuplicateValueId,
            "Enumeration members should have unique values",
            "Member '{0}' has the same value as member '{1}'; Parse and TryParse throw InvalidOperationException for this value",
            Category,
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description: "Lookups by value require each declared member to have a unique value."
        );

        private static readonly DiagnosticDescriptor DuplicateNameRule = new DiagnosticDescriptor(
            DuplicateNameId,
            "Enumeration members should have unique names",
            "Member '{0}' has the same name '{2}' as member '{1}'; ParseName and TryParseName throw InvalidOperationException for this name",
            Category,
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description: "Lookups by name require each declared member to have a unique name."
        );

        private static readonly DiagnosticDescriptor PublicConstructorRule = new DiagnosticDescriptor(
            PublicConstructorId,
            "Enumeration constructors should not be public",
            "Enumeration '{0}' declares a public constructor; instances created outside the declared members are not returned by lookups",
            Category,
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description: "Declare the constructors of a concrete enumeration as private so that the declared members form a closed set."
        );

        /// <inheritdoc />
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create(
            DuplicateValueRule,
            DuplicateNameRule,
            PublicConstructorRule
        );

        /// <inheritdoc />
        public override void Initialize(AnalysisContext context) {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();
            context.RegisterCompilationStartAction(startContext => {
                INamedTypeSymbol? enumerationBase = startContext.Compilation.GetTypeByMetadataName(EnumerationBaseMetadataName);
                if (enumerationBase is null) {
                    return;
                }

                INamedTypeSymbol? ignoreAttribute = startContext.Compilation.GetTypeByMetadataName(IgnoreAttributeMetadataName);
                startContext.RegisterSyntaxNodeAction(
                    nodeContext => AnalyzeClass(nodeContext, enumerationBase, ignoreAttribute),
                    SyntaxKind.ClassDeclaration
                );
            });
        }

        private static void AnalyzeClass(
            SyntaxNodeAnalysisContext context,
            INamedTypeSymbol enumerationBase,
            INamedTypeSymbol? ignoreAttribute
        ) {
            ClassDeclarationSyntax declaration = (ClassDeclarationSyntax)context.Node;
            if (!(context.SemanticModel.GetDeclaredSymbol(declaration, context.CancellationToken) is INamedTypeSymbol type)
                || !IsEnumeration(type, enumerationBase)
            ) {
                return;
            }

            if (!type.IsAbstract) {
                ReportPublicConstructors(context, declaration, type);
            }

            List<MemberDeclaration> members = new List<MemberDeclaration>();
            foreach (PropertyDeclarationSyntax property in declaration.Members.OfType<PropertyDeclarationSyntax>()) {
                MemberDeclaration? member = GetMemberDeclaration(context, property, type, enumerationBase, ignoreAttribute);
                if (member is not null) {
                    members.Add(member);
                }
            }

            ReportDuplicates(context, members);
        }

        private static bool IsEnumeration(INamedTypeSymbol type, INamedTypeSymbol enumerationBase) {
            for (INamedTypeSymbol? current = type.BaseType; current is not null; current = current.BaseType) {
                if (SymbolEqualityComparer.Default.Equals(current.OriginalDefinition, enumerationBase)) {
                    return SymbolEqualityComparer.Default.Equals(current.TypeArguments[0], type);
                }
            }

            return false;
        }

        private static void ReportPublicConstructors(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax declaration, INamedTypeSymbol type) {
            foreach (ConstructorDeclarationSyntax constructor in declaration.Members.OfType<ConstructorDeclarationSyntax>()) {
                if (constructor.Modifiers.Any(SyntaxKind.StaticKeyword)) {
                    continue;
                }

                IMethodSymbol? symbol = context.SemanticModel.GetDeclaredSymbol(constructor, context.CancellationToken);
                if (symbol?.DeclaredAccessibility == Accessibility.Public) {
                    context.ReportDiagnostic(Diagnostic.Create(PublicConstructorRule, constructor.Identifier.GetLocation(), type.Name));
                }
            }
        }

        private static MemberDeclaration? GetMemberDeclaration(
            SyntaxNodeAnalysisContext context,
            PropertyDeclarationSyntax property,
            INamedTypeSymbol type,
            INamedTypeSymbol enumerationBase,
            INamedTypeSymbol? ignoreAttribute
        ) {
            IPropertySymbol? symbol = context.SemanticModel.GetDeclaredSymbol(property, context.CancellationToken);
            if (symbol is null
                || !symbol.IsStatic
                || symbol.DeclaredAccessibility != Accessibility.Public
                || symbol.GetMethod is null
                || !SymbolEqualityComparer.Default.Equals(symbol.Type, type)
                || (ignoreAttribute is not null && symbol.GetAttributes().Any(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, ignoreAttribute)))
            ) {
                return null;
            }

            ExpressionSyntax? expression = property.Initializer?.Value ?? property.ExpressionBody?.Expression;
            if (expression is null
                || !(context.SemanticModel.GetOperation(expression, context.CancellationToken) is IObjectCreationOperation creation)
                || creation.Constructor is null
            ) {
                return null;
            }

            Dictionary<IParameterSymbol, Optional<object?>> arguments = MapArguments(creation.Arguments, new Dictionary<IParameterSymbol, Optional<object?>>(SymbolEqualityComparer.Default));
            (Optional<object?> value, Optional<string?> name) = ResolveValueAndName(context, creation.Constructor, arguments, enumerationBase, 0);

            return new MemberDeclaration(symbol.Name, property.Identifier.GetLocation(), value, name);
        }

        private static Dictionary<IParameterSymbol, Optional<object?>> MapArguments(
            ImmutableArray<IArgumentOperation> argumentOperations,
            Dictionary<IParameterSymbol, Optional<object?>> outerArguments
        ) {
            Dictionary<IParameterSymbol, Optional<object?>> result = new Dictionary<IParameterSymbol, Optional<object?>>(SymbolEqualityComparer.Default);

            foreach (IArgumentOperation argument in argumentOperations) {
                if (argument.Parameter is null) {
                    continue;
                }

                IOperation valueOperation = Unwrap(argument.Value);
                if (valueOperation.ConstantValue.HasValue) {
                    result[argument.Parameter] = new Optional<object?>(valueOperation.ConstantValue.Value);
                } else if (valueOperation is IParameterReferenceOperation parameterReference
                    && outerArguments.TryGetValue(parameterReference.Parameter, out Optional<object?> outerValue)
                ) {
                    result[argument.Parameter] = outerValue;
                }
            }

            return result;
        }

        private static IOperation Unwrap(IOperation operation) {
            while (operation is IConversionOperation conversion && !operation.ConstantValue.HasValue) {
                operation = conversion.Operand;
            }

            return operation;
        }

        private static (Optional<object?> Value, Optional<string?> Name) ResolveValueAndName(
            SyntaxNodeAnalysisContext context,
            IMethodSymbol constructor,
            Dictionary<IParameterSymbol, Optional<object?>> arguments,
            INamedTypeSymbol enumerationBase,
            int depth
        ) {
            // 建構子鏈過深時視為無法判定，避免異常宣告造成無限遞迴
            if (depth > 8) {
                return (default, default);
            }

            ConstructorDeclarationSyntax? declaration = constructor.DeclaringSyntaxReferences
                .Select(x => x.GetSyntax(context.CancellationToken))
                .OfType<ConstructorDeclarationSyntax>()
                .FirstOrDefault(x => x.SyntaxTree == context.SemanticModel.SyntaxTree);

            bool isEnumerationBase = SymbolEqualityComparer.Default.Equals(constructor.ContainingType.OriginalDefinition, enumerationBase);
            if (!isEnumerationBase
                && declaration?.Initializer is not null
                && context.SemanticModel.GetOperation(declaration.Initializer, context.CancellationToken) is IInvocationOperation initializer
            ) {
                Dictionary<IParameterSymbol, Optional<object?>> innerArguments = MapArguments(initializer.Arguments, arguments);
                return ResolveValueAndName(context, initializer.TargetMethod, innerArguments, enumerationBase, depth + 1);
            }

            if (!isEnumerationBase && !constructor.DeclaringSyntaxReferences.IsEmpty) {
                return (default, default);
            }

            // 中繼資料中的建構子（例如 IntEnumeration<T>）沿用 value 與 name 參數名稱傳遞給基底
            Optional<object?> value = GetArgument(constructor, arguments, ValueParameterName);
            Optional<object?> nameArgument = GetArgument(constructor, arguments, NameParameterName);
            bool hasNameParameter = constructor.Parameters.Any(x => x.Name == NameParameterName);

            Optional<string?> name = hasNameParameter
                ? nameArgument.HasValue ? new Optional<string?>(nameArgument.Value as string) : default
                : value.HasValue ? new Optional<string?>(Convert.ToString(value.Value, CultureInfo.InvariantCulture)) : default;

            return (value, name);
        }

        private static Optional<object?> GetArgument(
            IMethodSymbol constructor,
            Dictionary<IParameterSymbol, Optional<object?>> arguments,
            string parameterName
        ) {
            IParameterSymbol? parameter = constructor.Parameters.FirstOrDefault(x => x.Name == parameterName);
            return parameter is not null && arguments.TryGetValue(parameter, out Optional<object?> value) ? value : default;
        }

        private static void ReportDuplicates(SyntaxNodeAnalysisContext context, List<MemberDeclaration> members) {
            Dictionary<object, MemberDeclaration> values = new Dictionary<object, MemberDeclaration>();
            Dictionary<string, MemberDeclaration> names = new Dictionary<string, MemberDeclaration>(StringComparer.Ordinal);
            object nullKey = new object();

            foreach (MemberDeclaration member in members) {
                if (member.Value.HasValue) {
                    object key = member.Value.Value ?? nullKey;
                    if (values.TryGetValue(key, out MemberDeclaration? first)) {
                        context.ReportDiagnostic(Diagnostic.Create(DuplicateValueRule, member.Location, member.PropertyName, first.PropertyName));
                    } else {
                        values.Add(key, member);
                    }
                }

                if (member.Name.HasValue && member.Name.Value is not null) {
                    if (names.TryGetValue(member.Name.Value, out MemberDeclaration? first)) {
                        context.ReportDiagnostic(Diagnostic.Create(
                            DuplicateNameRule,
                            member.Location,
                            member.PropertyName,
                            first.PropertyName,
                            member.Name.Value
                        ));
                    } else {
                        names.Add(member.Name.Value, member);
                    }
                }
            }
        }

        private sealed class MemberDeclaration {
            public MemberDeclaration(string propertyName, Location location, Optional<object?> value, Optional<string?> name) {
                PropertyName = propertyName;
                Location = location;
                Value = value;
                Name = name;
            }

            public string PropertyName { get; }

            public Location Location { get; }

            public Optional<object?> Value { get; }

            public Optional<string?> Name { get; }
        }
    }
}
