using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class FloatEnumerationTests {
        [Test]
        public void ImplicitOperator_FloatEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericFloatEnumeration.One;

            Assert.That(actual, Is.EqualTo(1F));
        }
    }
}
