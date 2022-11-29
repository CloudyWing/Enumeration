using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class CharEnumerationTests {
        [Test]
        public void ImplicitOperator_ToUShort() {
            ushort act = NumericCharEnumeration.One;
            ushort result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToInt() {
            int act = NumericCharEnumeration.One;
            int result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToUInt() {
            uint act = NumericCharEnumeration.One;
            uint result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericCharEnumeration.One;
            long result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToULong() {
            ulong act = NumericCharEnumeration.One;
            ulong result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericCharEnumeration.One;
            float result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericCharEnumeration.One;
            double result = (char)1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericCharEnumeration.One;
            decimal result = (char)1;
            act.Should().Be(result);
        }
    }
}
