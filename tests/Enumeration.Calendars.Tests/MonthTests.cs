namespace CloudyWing.Enumeration.Calendars.Tests {
    internal class MonthTests {
        [Test]
        public void GetAll_Always_ReturnsTwelveMonthsInOrder() {
            int[] actual = Month.GetAll().Select(x => x.Value).ToArray();

            Assert.That(actual, Is.EqualTo(Enumerable.Range(1, 12)).AsCollection);
        }

        [Test]
        [TestCase(1, "一月", "January", "一", "Jan")]
        [TestCase(11, "十一月", "November", "十一", "Nov")]
        [TestCase(12, "十二月", "December", "十二", "Dec")]
        public void Parse_DeclaredValue_ReturnsMonthWithExpectedNames(
            int value,
            string name,
            string englishName,
            string nameAbbreviation,
            string englishAbbreviation
        ) {
            Month actual = Month.Parse(value);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual.Name, Is.EqualTo(name));
                Assert.That(actual.EnglishName, Is.EqualTo(englishName));
                Assert.That(actual.NameAbbreviation, Is.EqualTo(nameAbbreviation));
                Assert.That(actual.EnglishAbbreviation, Is.EqualTo(englishAbbreviation));
            }
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(12, 1, 1)]
        [TestCase(1, -1, 12)]
        [TestCase(3, 24, 3)]
        [TestCase(3, -25, 2)]
        [TestCase(6, int.MaxValue, 1)]
        [TestCase(6, int.MinValue, 10)]
        public void AdditionOperator_Offset_ReturnsWrappedMonth(int value, int offset, int expected) {
            Month actual = Month.Parse(value) + offset;

            Assert.That(actual, Is.SameAs(Month.Parse(expected)));
        }

        [Test]
        [TestCase(1, 1, 12)]
        [TestCase(12, -1, 1)]
        [TestCase(6, int.MaxValue, 11)]
        [TestCase(6, int.MinValue, 2)]
        public void SubtractionOperator_Offset_ReturnsWrappedMonth(int value, int offset, int expected) {
            Month actual = Month.Parse(value) - offset;

            Assert.That(actual, Is.SameAs(Month.Parse(expected)));
        }

        [Test]
        public void IncrementOperator_December_ReturnsJanuary() {
            Month month = Month.December;

            month++;

            Assert.That(month, Is.SameAs(Month.January));
        }

        [Test]
        public void DecrementOperator_January_ReturnsDecember() {
            Month month = Month.January;

            month--;

            Assert.That(month, Is.SameAs(Month.December));
        }

        [Test]
        public void ExplicitOperator_UndeclaredValue_ThrowsInvalidCastException() {
            Assert.Throws<InvalidCastException>(() => _ = (Month)13);
        }
    }
}
