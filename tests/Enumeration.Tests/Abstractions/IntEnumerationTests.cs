using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class IntEnumerationTests {
        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericIntEnumeration.One;
            long result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericIntEnumeration.One;
            float result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericIntEnumeration.One;
            double result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericIntEnumeration.One;
            decimal result = 1;
            act.Should().Be(result);
        }
    }
}
