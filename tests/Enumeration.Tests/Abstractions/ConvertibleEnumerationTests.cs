using CloudyWing.Enumeration.Abstractions;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ConvertibleEnumerationTests {
        private static readonly IEnumerable<object[]> toTypeTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One.Value, BasicIntEnumeration.One.GetType(), BasicIntEnumeration.One },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One.Value, typeof(int), 1 },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One.Value, typeof(decimal), 1M }
        };

        [Test]
        public void GetTypeCode() {
            TypeCode act = ((IConvertible)BasicIntEnumeration.One).GetTypeCode();
            act.Should().Be(TypeCode.Int32);
        }

        [Test]
        [TestCase(null)]
        public void ToBoolean(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            bool act = ((IConvertible)enumeration).ToBoolean(provider);
            bool result = ((IConvertible)enumeration.Value).ToBoolean(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToChar(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            char act = ((IConvertible)enumeration).ToChar(provider);
            char result = ((IConvertible)enumeration.Value).ToChar(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToSByte(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            sbyte act = ((IConvertible)enumeration).ToSByte(provider);
            sbyte result = ((IConvertible)enumeration.Value).ToSByte(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToByte(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            byte act = ((IConvertible)enumeration).ToByte(provider);
            byte result = ((IConvertible)enumeration.Value).ToByte(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToInt16(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            short act = ((IConvertible)enumeration).ToInt16(provider);
            short result = ((IConvertible)enumeration.Value).ToInt16(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToUInt16(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            ushort act = ((IConvertible)enumeration).ToUInt16(provider);
            ushort result = ((IConvertible)enumeration.Value).ToUInt16(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToInt32(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int act = ((IConvertible)enumeration).ToInt32(provider);
            int result = ((IConvertible)enumeration.Value).ToInt32(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToUInt32(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            uint act = ((IConvertible)enumeration).ToUInt32(provider);
            uint result = ((IConvertible)enumeration.Value).ToUInt32(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToInt64(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            long act = ((IConvertible)enumeration).ToInt64(provider);
            long result = ((IConvertible)enumeration.Value).ToInt64(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToUInt64(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            ulong act = ((IConvertible)enumeration).ToUInt64(provider);
            ulong result = ((IConvertible)enumeration.Value).ToUInt64(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToSingle(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            float act = ((IConvertible)enumeration).ToSingle(provider);
            float result = ((IConvertible)enumeration.Value).ToSingle(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToDouble(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            double act = ((IConvertible)enumeration).ToDouble(provider);
            double result = ((IConvertible)enumeration.Value).ToDouble(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToDecimal(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            decimal act = ((IConvertible)enumeration).ToDecimal(provider);
            decimal result = ((IConvertible)enumeration.Value).ToDecimal(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCase(null)]
        public void ToDateTime(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            Func<DateTime> act = () => ((IConvertible)enumeration).ToDateTime(provider);

            act.Should().Throw<InvalidCastException>();
        }

        [Test]
        [TestCase(null)]
        public void ToString(IFormatProvider provider) {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            string act = ((IConvertible)enumeration).ToString(provider);
            string result = enumeration.Value.ToString(provider);

            act.Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(toTypeTestSource))]
        public void ToType<TEnum, TValue>(TEnum enumeration, TValue value, Type destType, object result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            object act = ((IConvertible)enumeration).ToType(destType, null);

            act.Should().Be(result);
        }

        [Test]
        public void ToType_ToOtherEnumeration() {
            Func<object> act = () => ((IConvertible)BasicIntEnumeration.One).ToType(typeof(BasicIntEnumeration2), null);

            act.Should()
                .Throw<InvalidCastException>()
                .WithMessage($"Invalid cast from '{typeof(BasicIntEnumeration).FullName}' to '{typeof(BasicIntEnumeration2).FullName}'.");
        }
    }
}
