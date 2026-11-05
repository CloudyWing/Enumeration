#if NET10_0_OR_GREATER // 函式庫只有 net10.0 組件實作 IParsable，net8.0 測試使用 netstandard2.0 組件
using System.Globalization;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class EnumerationBaseParsableTests {
        [Test]
        [TestCase("One")]
        [TestCase("1")]
        public void Parse_NameOrValueText_ReturnsMatchingInstance(string text) {
            BasicIntEnumeration actual = Parse<BasicIntEnumeration>(text, CultureInfo.InvariantCulture);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void Parse_UndeclaredText_ThrowsFormatException() {
            Assert.Throws<FormatException>(() => Parse<BasicIntEnumeration>("Nine", CultureInfo.InvariantCulture));
        }

        [Test]
        public void Parse_NullText_ThrowsArgumentNullException() {
            Assert.Throws<ArgumentNullException>(() => Parse<BasicIntEnumeration>(null!, CultureInfo.InvariantCulture));
        }

        [Test]
        public void TryParse_ValueTextWithCulture_UsesProvider() {
            bool actual = TryParse("0,5", new CultureInfo("de-DE"), out FractionDoubleEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.True);
                Assert.That(enumeration, Is.SameAs(FractionDoubleEnumeration.Half));
            }
        }

        [Test]
        public void TryParse_GuidValueText_ReturnsMatchingInstance() {
            bool actual = TryParse("11111111-1111-1111-1111-111111111111", null, out BasicGuidEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.True);
                Assert.That(enumeration, Is.SameAs(BasicGuidEnumeration.AllOne));
            }
        }

        [Test]
        public void TryParse_ValueTypeWithoutTextConversion_MatchesFormattedValue() {
            bool actual = TryParse("a", null, out OrderKeyEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.True);
                Assert.That(enumeration, Is.SameAs(OrderKeyEnumeration.Lower));
            }
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("abc")]
        public void TryParse_InvalidText_ReturnsFalse(string? text) {
            bool actual = TryParse(text, CultureInfo.InvariantCulture, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.False);
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        [TestCase("Two")]
        [TestCase("2")]
        public void SpanParse_NameOrValueText_ReturnsMatchingInstance(string text) {
            BasicIntEnumeration actual = SpanParse<BasicIntEnumeration>($" {text} ".AsSpan(1, text.Length), CultureInfo.InvariantCulture);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.Two));
        }

        [Test]
        public void SpanParse_UndeclaredText_ThrowsFormatException() {
            Assert.Throws<FormatException>(() => SpanParse<BasicIntEnumeration>("Nine".AsSpan(), CultureInfo.InvariantCulture));
        }

        private static T Parse<T>(string text, IFormatProvider? provider) where T : IParsable<T> {
            return T.Parse(text, provider);
        }

        private static bool TryParse<T>(string? text, IFormatProvider? provider, out T? result) where T : IParsable<T> {
            return T.TryParse(text, provider, out result);
        }

        private static T SpanParse<T>(ReadOnlySpan<char> text, IFormatProvider? provider) where T : ISpanParsable<T> {
            return T.Parse(text, provider);
        }
    }
}
#endif
