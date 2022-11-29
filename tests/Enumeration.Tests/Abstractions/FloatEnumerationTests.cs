using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class FloatEnumerationTests {
        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericFloatEnumeration.One;
            double result = 1F;
            act.Should().Be(result);
        }
    }
}
