using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class LongEnumerationTests {
        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericLongEnumeration.One;
            float result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericLongEnumeration.One;
            double result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericLongEnumeration.One;
            decimal result = 1U;
            act.Should().Be(result);
        }
    }
}
