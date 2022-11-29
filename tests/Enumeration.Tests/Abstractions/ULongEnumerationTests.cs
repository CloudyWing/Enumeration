using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ULongEnumerationTests {
        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericULongEnumeration.One;
            float result = 1UL;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericULongEnumeration.One;
            double result = 1UL;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericULongEnumeration.One;
            decimal result = 1UL;
            act.Should().Be(result);
        }
    }
}
