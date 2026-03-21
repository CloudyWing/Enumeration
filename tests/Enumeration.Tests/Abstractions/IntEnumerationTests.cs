using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class IntEnumerationTests {
        [Test]
        public void ImplicitOperator_IntEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_IntEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_IntEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_IntEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericIntEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
