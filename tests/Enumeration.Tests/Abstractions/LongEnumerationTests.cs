using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class LongEnumerationTests {
        [Test]
        public void ImplicitOperator_LongEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericLongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_LongEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericLongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_LongEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericLongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }
    }
}
