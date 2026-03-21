using CloudyWing.Enumeration.Abstractions;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ConvertibleEnumerationTests {
        private static readonly IEnumerable<object[]> ToTypeTestSource = [
            [BasicIntEnumeration.One, BasicIntEnumeration.One.Value, BasicIntEnumeration.One.GetType(), BasicIntEnumeration.One],
            [BasicIntEnumeration.One, BasicIntEnumeration.One.Value, typeof(int), 1],
            [BasicIntEnumeration.One, BasicIntEnumeration.One.Value, typeof(decimal), 1M]
        ];

        [Test]
        public void GetTypeCode_IntEnumeration_ReturnsInt32TypeCode() {
            IConvertible convertible = BasicIntEnumeration.One;

            TypeCode actual = convertible.GetTypeCode();

            Assert.That(actual, Is.EqualTo(TypeCode.Int32));
        }

        [Test]
        [TestCase(null)]
        public void ToBoolean_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            bool expected = ((IConvertible)enumeration.Value).ToBoolean(provider);

            bool actual = ((IConvertible)enumeration).ToBoolean(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToChar_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            char expected = ((IConvertible)enumeration.Value).ToChar(provider);

            char actual = ((IConvertible)enumeration).ToChar(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToSByte_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            sbyte expected = ((IConvertible)enumeration.Value).ToSByte(provider);

            sbyte actual = ((IConvertible)enumeration).ToSByte(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToByte_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            byte expected = ((IConvertible)enumeration.Value).ToByte(provider);

            byte actual = ((IConvertible)enumeration).ToByte(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToInt16_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            short expected = ((IConvertible)enumeration.Value).ToInt16(provider);

            short actual = ((IConvertible)enumeration).ToInt16(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToUInt16_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            ushort expected = ((IConvertible)enumeration.Value).ToUInt16(provider);

            ushort actual = ((IConvertible)enumeration).ToUInt16(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToInt32_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int expected = ((IConvertible)enumeration.Value).ToInt32(provider);

            int actual = ((IConvertible)enumeration).ToInt32(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToUInt32_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            uint expected = ((IConvertible)enumeration.Value).ToUInt32(provider);

            uint actual = ((IConvertible)enumeration).ToUInt32(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToInt64_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            long expected = ((IConvertible)enumeration.Value).ToInt64(provider);

            long actual = ((IConvertible)enumeration).ToInt64(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToUInt64_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            ulong expected = ((IConvertible)enumeration.Value).ToUInt64(provider);

            ulong actual = ((IConvertible)enumeration).ToUInt64(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToSingle_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            float expected = ((IConvertible)enumeration.Value).ToSingle(provider);

            float actual = ((IConvertible)enumeration).ToSingle(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToDouble_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            double expected = ((IConvertible)enumeration.Value).ToDouble(provider);

            double actual = ((IConvertible)enumeration).ToDouble(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToDecimal_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            decimal expected = ((IConvertible)enumeration.Value).ToDecimal(provider);

            decimal actual = ((IConvertible)enumeration).ToDecimal(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null)]
        public void ToDateTime_NullFormatProvider_ThrowsInvalidCastException(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;

            void action() => ((IConvertible)enumeration).ToDateTime(provider);

            Assert.Throws<InvalidCastException>(() => action());
        }

        [Test]
        [TestCase(null)]
        public void ToString_NullFormatProvider_ReturnsUnderlyingValueConversion(IFormatProvider? provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            string expected = enumeration.Value.ToString(provider);

            string actual = ((IConvertible)enumeration).ToString(provider);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCaseSource(nameof(ToTypeTestSource))]
        public void ToType_ValidDestinationType_ReturnsConvertedValue<TEnum, TValue>(TEnum enumeration, TValue _, Type destType, object expected)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            object actual = ((IConvertible)enumeration).ToType(destType, null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToType_OtherEnumerationType_ThrowsInvalidCastExceptionWithMessage() {
            string expectedMessage = $"Invalid cast from '{typeof(BasicIntEnumeration).FullName}' to '{typeof(BasicIntEnumeration2).FullName}'.";

            var ex = Assert.Throws<InvalidCastException>(() => ((IConvertible)BasicIntEnumeration.One).ToType(typeof(BasicIntEnumeration2), null));

            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }
}
