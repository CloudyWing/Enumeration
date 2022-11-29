using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class SByteEnumerationTests {
        [Test]
        public void ImplicitOperator_ToShort() {
            short act = NumericSByteEnumeration.One;
            short result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToInt() {
            int act = NumericSByteEnumeration.One;
            int result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericSByteEnumeration.One;
            long result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericSByteEnumeration.One;
            float result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericSByteEnumeration.One;
            double result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericSByteEnumeration.One;
            decimal result = 1;
            act.Should().Be(result);
        }
    }
}
