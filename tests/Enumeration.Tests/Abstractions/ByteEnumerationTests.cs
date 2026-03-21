using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ByteEnumerationTests {
        [Test]
        public void ImplicitOperator_ByteEnumerationToShort_ConvertsCorrectly() {
            short actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToInt_ConvertsCorrectly() {
            int actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToUInt_ConvertsCorrectly() {
            uint actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToULong_ConvertsCorrectly() {
            ulong actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ImplicitOperator_ByteEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericByteEnumeration.One;

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
