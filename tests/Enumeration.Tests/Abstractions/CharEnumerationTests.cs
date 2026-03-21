using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class CharEnumerationTests {
        [Test]
        public void ImplicitOperator_CharEnumerationToUShort_ConvertsCorrectly() {
            ushort actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((ushort)(char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToInt_ConvertsCorrectly() {
            int actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToUInt_ConvertsCorrectly() {
            uint actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((uint)(char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToLong_ConvertsCorrectly() {
            long actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToULong_ConvertsCorrectly() {
            ulong actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((ulong)(char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToFloat_ConvertsCorrectly() {
            float actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((float)(char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToDouble_ConvertsCorrectly() {
            double actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((double)(char)1));
        }

        [Test]
        public void ImplicitOperator_CharEnumerationToDecimal_ConvertsCorrectly() {
            decimal actual = NumericCharEnumeration.One;

            Assert.That(actual, Is.EqualTo((decimal)(char)1));
        }
    }
}
