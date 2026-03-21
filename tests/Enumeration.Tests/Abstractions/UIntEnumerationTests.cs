using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class UIntEnumerationTests {
        [Test]
        public void ImplicitOperator_UIntEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericUIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_UIntEnumerationToULong_ConvertsCorrectly() {
            ulong actual = NumericUIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_UIntEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericUIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_UIntEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericUIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }

        [Test]
        public void ImplicitOperator_UIntEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericUIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1U));
        }
    }
}
