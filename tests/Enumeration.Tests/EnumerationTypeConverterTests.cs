using System.ComponentModel;
using System.Globalization;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests {
    internal class EnumerationTypeConverterTests {
        private readonly EnumerationTypeConverter<ConverterIntEnumeration, int> converter = new();

        [Test]
        public void Register_CalledTwice_TypeDescriptorReturnsEnumerationConverter() {
            EnumerationTypeConverter.Register<ConverterIntEnumeration, int>();
            EnumerationTypeConverter.Register<ConverterIntEnumeration, int>();

            TypeConverter actual = TypeDescriptor.GetConverter(typeof(ConverterIntEnumeration));

            Assert.That(actual, Is.TypeOf<EnumerationTypeConverter<ConverterIntEnumeration, int>>());
        }

        [Test]
        [TestCase("Active")]
        [TestCase("1")]
        public void ConvertFromInvariantString_NameOrValueText_ReturnsMatchingInstance(string text) {
            object? actual = converter.ConvertFromInvariantString(text);

            Assert.That(actual, Is.SameAs(ConverterIntEnumeration.Active));
        }

        [Test]
        public void ConvertFrom_UnderlyingValue_ReturnsMatchingInstance() {
            object? actual = converter.ConvertFrom(null, CultureInfo.InvariantCulture, 2);

            Assert.That(actual, Is.SameAs(ConverterIntEnumeration.Inactive));
        }

        [Test]
        [TestCase("")]
        [TestCase("  ")]
        public void ConvertFromInvariantString_EmptyText_ReturnsNull(string text) {
            object? actual = converter.ConvertFromInvariantString(text);

            Assert.That(actual, Is.Null);
        }

        [Test]
        [TestCase("Unknown")]
        [TestCase("9")]
        public void ConvertFromInvariantString_UndeclaredText_ThrowsFormatException(string text) {
            Assert.Throws<FormatException>(() => converter.ConvertFromInvariantString(text));
        }

        [Test]
        public void ConvertFrom_UnsupportedSource_ThrowsNotSupportedException() {
            Assert.Throws<NotSupportedException>(() => converter.ConvertFrom(null, CultureInfo.InvariantCulture, 1.5D));
        }

        [Test]
        public void ConvertTo_String_ReturnsName() {
            object? actual = converter.ConvertTo(ConverterIntEnumeration.Inactive, typeof(string));

            Assert.That(actual, Is.EqualTo(nameof(ConverterIntEnumeration.Inactive)));
        }

        [Test]
        public void ConvertTo_ValueType_ReturnsValue() {
            object? actual = converter.ConvertTo(ConverterIntEnumeration.Inactive, typeof(int));

            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        [TestCase(typeof(string), true)]
        [TestCase(typeof(int), true)]
        [TestCase(typeof(double), false)]
        public void CanConvertFrom_SourceType_ReturnsExpectedResult(Type sourceType, bool expected) {
            bool actual = converter.CanConvertFrom(sourceType);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Active", true)]
        [TestCase("2", true)]
        [TestCase("Unknown", false)]
        public void IsValid_Text_ReturnsExpectedResult(string text, bool expected) {
            bool actual = converter.IsValid(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetStandardValues_Always_ReturnsDeclaredMembers() {
            System.Collections.ICollection? actual = converter.GetStandardValues();

            Assert.That(actual, Is.EqualTo(new[] { ConverterIntEnumeration.Active, ConverterIntEnumeration.Inactive }).AsCollection);
        }
    }
}
