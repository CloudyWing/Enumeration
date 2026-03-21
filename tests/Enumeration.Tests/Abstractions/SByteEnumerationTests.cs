using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class SByteEnumerationTests {
        [Test]
        public void ImplicitOperator_SByteEnumerationToShort_ConvertsCorrectly() {
            short actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_SByteEnumerationToInt_ConvertsCorrectly() {
            int actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_SByteEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_SByteEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_SByteEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_SByteEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericSByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
