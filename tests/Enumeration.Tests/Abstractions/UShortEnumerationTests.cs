using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class UShortEnumerationTests {
        [Test]
        public void ImplicitOperator_UShortEnumerationToInt_ConvertsCorrectly() {
            int actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToUInt_ConvertsCorrectly() {
            uint actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToULong_ConvertsCorrectly() {
            ulong actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_UShortEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericUShortEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
