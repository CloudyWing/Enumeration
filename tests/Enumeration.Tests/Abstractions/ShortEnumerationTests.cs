using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ShortEnumerationTests {
        [Test]
        public void ImplicitOperator_ShortEnumerationToInt_ConvertsCorrectly() {
            int actual = NumericShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ShortEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ShortEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ShortEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ShortEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
