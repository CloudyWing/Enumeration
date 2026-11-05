namespace CloudyWing.Enumeration.Calendars.Tests {
    internal class WeekDayTests {
        [Test]
        public void GetAll_Always_ReturnsSevenDaysStartingFromSunday() {
            int[] actual = WeekDay.GetAll().Select(x => x.Value).ToArray();

            Assert.That(actual, Is.EqualTo(Enumerable.Range(0, 7)).AsCollection);
        }

        [Test]
        [TestCase(0, "星期日", "Sunday", "日", "(日)", "Sun")]
        [TestCase(3, "星期三", "Wednesday", "三", "(三)", "Wed")]
        [TestCase(6, "星期六", "Saturday", "六", "(六)", "Sat")]
        public void Parse_DeclaredValue_ReturnsWeekDayWithExpectedNames(
            int value,
            string name,
            string englishName,
            string nameAbbreviation,
            string nameAbbreviationWithBracket,
            string englishAbbreviation
        ) {
            WeekDay actual = WeekDay.Parse(value);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual.Name, Is.EqualTo(name));
                Assert.That(actual.EnglishName, Is.EqualTo(englishName));
                Assert.That(actual.NameAbbreviation, Is.EqualTo(nameAbbreviation));
                Assert.That(actual.NameAbbreviationWithBracket, Is.EqualTo(nameAbbreviationWithBracket));
                Assert.That(actual.EnglishAbbreviation, Is.EqualTo(englishAbbreviation));
            }
        }

        [Test]
        [TestCase(DayOfWeek.Sunday)]
        [TestCase(DayOfWeek.Thursday)]
        [TestCase(DayOfWeek.Saturday)]
        public void ImplicitOperator_DayOfWeekRoundTrip_ReturnsSameDay(DayOfWeek dayOfWeek) {
            WeekDay weekDay = dayOfWeek;

            DayOfWeek actual = weekDay;

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(dayOfWeek));
                Assert.That(weekDay.Value, Is.EqualTo((int)dayOfWeek));
            }
        }

        [Test]
        [TestCase(6, 1, 0)]
        [TestCase(0, -1, 6)]
        [TestCase(2, 14, 2)]
        [TestCase(2, -15, 1)]
        [TestCase(3, int.MaxValue, 4)]
        [TestCase(3, int.MinValue, 1)]
        public void AdditionOperator_Offset_ReturnsWrappedWeekDay(int value, int offset, int expected) {
            WeekDay actual = WeekDay.Parse(value) + offset;

            Assert.That(actual, Is.SameAs(WeekDay.Parse(expected)));
        }

        [Test]
        [TestCase(0, 1, 6)]
        [TestCase(6, -1, 0)]
        [TestCase(3, int.MaxValue, 2)]
        [TestCase(3, int.MinValue, 5)]
        public void SubtractionOperator_Offset_ReturnsWrappedWeekDay(int value, int offset, int expected) {
            WeekDay actual = WeekDay.Parse(value) - offset;

            Assert.That(actual, Is.SameAs(WeekDay.Parse(expected)));
        }

        [Test]
        public void IncrementOperator_Saturday_ReturnsSunday() {
            WeekDay weekDay = WeekDay.Saturday;

            weekDay++;

            Assert.That(weekDay, Is.SameAs(WeekDay.Sunday));
        }

        [Test]
        public void DecrementOperator_Sunday_ReturnsSaturday() {
            WeekDay weekDay = WeekDay.Sunday;

            weekDay--;

            Assert.That(weekDay, Is.SameAs(WeekDay.Saturday));
        }
    }
}
