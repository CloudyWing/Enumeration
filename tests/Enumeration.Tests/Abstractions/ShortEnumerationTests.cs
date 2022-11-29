using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ShortEnumerationTests {
        [Test]
        public void ImplicitOperator_ToInt() {
            int act = NumericShortEnumeration.One;
            int result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericShortEnumeration.One;
            long result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericShortEnumeration.One;
            float result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericShortEnumeration.One;
            double result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericShortEnumeration.One;
            decimal result = 1;
            act.Should().Be(result);
        }
    }
}
