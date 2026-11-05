using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal partial class NumericEnumerationTests {
        private static readonly NumericIntEnumeration? NullInt = null;
        private static readonly NumericDoubleEnumeration? NullDouble = null;
        private static readonly NumericCharEnumeration? NullChar = null;
        private static readonly NumericULongEnumeration? NullULong = null;

        [Test]
        public void EqualityOperators_NullIntEnumerationAndNumber_MatchBaseOperatorSemantics() {
            using (Assert.EnterMultipleScope()) {
                Assert.That(NullInt! == 1L, Is.False);
                Assert.That(1L == NullInt!, Is.False);
                Assert.That(NullInt! != 1L, Is.True);
                Assert.That(1L != NullInt!, Is.True);
                Assert.That(NullInt! == (short)1, Is.False);
                Assert.That(NullInt! == 1, Is.False);
                Assert.That(NullInt! != 1, Is.True);
            }
        }

        [Test]
        public void ComparisonOperators_NullIntEnumerationAndNumber_ReturnFalse() {
            using (Assert.EnterMultipleScope()) {
                Assert.That(NullInt! > 0L, Is.False);
                Assert.That(NullInt! < 2L, Is.False);
                Assert.That(NullInt! >= 1L, Is.False);
                Assert.That(NullInt! <= 1L, Is.False);
                Assert.That(2L > NullInt!, Is.False);
                Assert.That(0L < NullInt!, Is.False);
                Assert.That(1L >= NullInt!, Is.False);
                Assert.That(1L <= NullInt!, Is.False);
                Assert.That(NullInt! > 0, Is.False);
            }
        }

        [Test]
        public void Operators_NullDoubleEnumerationAndNumber_DoNotThrow() {
            using (Assert.EnterMultipleScope()) {
                Assert.That(NullDouble! == 1L, Is.False);
                Assert.That(NullDouble! != 1, Is.True);
                Assert.That(1F < NullDouble!, Is.False);
            }
        }

        [Test]
        public void Operators_NullCharAndULongEnumerations_DoNotThrow() {
            using (Assert.EnterMultipleScope()) {
                Assert.That(NullChar! == 1, Is.False);
                Assert.That(1 != NullChar!, Is.True);
                Assert.That(NullULong! == 1U, Is.False);
            }
        }
    }
}
