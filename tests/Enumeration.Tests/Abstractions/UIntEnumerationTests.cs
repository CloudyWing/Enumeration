using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class UIntEnumerationTests {
        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericUIntEnumeration.One;
            long result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToULong() {
            ulong act = NumericUIntEnumeration.One;
            ulong result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericUIntEnumeration.One;
            float result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericUIntEnumeration.One;
            double result = 1U;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericUIntEnumeration.One;
            decimal result = 1U;
            act.Should().Be(result);
        }
    }
}
