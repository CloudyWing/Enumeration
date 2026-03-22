using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ULongEnumerationTests {
        [Test]
        public void ImplicitOperator_ULongEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericULongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1UL));
        }

        [Test]
        public void ImplicitOperator_ULongEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericULongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1UL));
        }

        [Test]
        public void ImplicitOperator_ULongEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericULongEnumeration.One;

            Assert.That(actual, Is.EqualTo(1UL));
        }
    }
}
