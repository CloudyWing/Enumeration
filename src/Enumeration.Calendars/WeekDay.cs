using System;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Calendars {
    /// <summary>The week day enumeration.</summary>
    /// <seealso cref="IntEnumeration&lt;Month&gt;" />
    [Serializable]
    public sealed class WeekDay : IntEnumeration<WeekDay> {
        private static readonly Lazy<WeekDay> sunday = new Lazy<WeekDay>(() => new WeekDay(0, "星期日", nameof(Sunday)));
        private static readonly Lazy<WeekDay> monday = new Lazy<WeekDay>(() => new WeekDay(1, "星期一", nameof(Monday)));
        private static readonly Lazy<WeekDay> tuesday = new Lazy<WeekDay>(() => new WeekDay(2, "星期二", nameof(Tuesday)));
        private static readonly Lazy<WeekDay> wednesday = new Lazy<WeekDay>(() => new WeekDay(3, "星期三", nameof(Wednesday)));
        private static readonly Lazy<WeekDay> thursday = new Lazy<WeekDay>(() => new WeekDay(4, "星期四", nameof(Thursday)));
        private static readonly Lazy<WeekDay> friday = new Lazy<WeekDay>(() => new WeekDay(5, "星期五", nameof(Friday)));
        private static readonly Lazy<WeekDay> saturday = new Lazy<WeekDay>(() => new WeekDay(6, "星期六", nameof(Saturday)));

        private WeekDay(int value, string name, string englishName) : base(value, name) {
            EnglishName = englishName;
        }

        /// <summary>Performs an implicit conversion from <see cref="WeekDay" /> to <see cref="DayOfWeek" />.</summary>
        /// <param name="weekDay">The week day.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DayOfWeek(WeekDay weekDay) {
            return (DayOfWeek)weekDay.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="DayOfWeek" /> to <see cref="WeekDay" />.</summary>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator WeekDay(DayOfWeek dayOfWeek) {
            return (WeekDay)(int)dayOfWeek;
        }

        /// <summary>Implements the operator +.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static WeekDay operator +(WeekDay left, int right) {
            int remainder = (left.Value + right) % 7;
            return (WeekDay)(remainder < 0 ? remainder + 7 : remainder);
        }

        /// <summary>Implements the operator -.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static WeekDay operator -(WeekDay left, int right) {
            return left + (0 - right);
        }

        /// <summary>Implements the operator ++.</summary>
        /// <param name="weekDay">The week day.</param>
        /// <returns>The result of the operator.</returns>
        public static WeekDay operator ++(WeekDay weekDay) {
            return weekDay + 1;
        }

        /// <summary>Implements the operator --.</summary>
        /// <param name="weekDay">The week day.</param>
        /// <returns>The result of the operator.</returns>
        public static WeekDay operator --(WeekDay weekDay) {
            return weekDay - 1;
        }

        /// <summary>Gets the sunday.</summary>
        /// <value>The sunday.</value>
        public static WeekDay Sunday => sunday.Value;

        /// <summary>Gets the monday.</summary>
        /// <value>The monday.</value>
        public static WeekDay Monday => monday.Value;

        /// <summary>Gets the tuesday.</summary>
        /// <value>The tuesday.</value>
        public static WeekDay Tuesday => tuesday.Value;

        /// <summary>Gets the wednesday.</summary>
        /// <value>The wednesday.</value>
        public static WeekDay Wednesday => wednesday.Value;

        /// <summary>Gets the thursday.</summary>
        /// <value>The thursday.</value>
        public static WeekDay Thursday => thursday.Value;

        /// <summary>Gets the friday.</summary>
        /// <value>The friday.</value>
        public static WeekDay Friday => friday.Value;

        /// <summary>Gets the saturday.</summary>
        /// <value>The saturday.</value>
        public static WeekDay Saturday => saturday.Value;

        /// <summary>Gets the name of the english.</summary>
        /// <value>The name of the english.</value>
        public string EnglishName { get; }

        /// <summary>Gets the name abbreviation.</summary>
        /// <value>The name abbreviation.</value>
        public string NameAbbreviation => Name.Substring(2);

        /// <summary>Gets the name abbreviation with bracket.</summary>
        /// <value>The name abbreviation with bracket.</value>
        public string NameAbbreviationWithBracket => $"({NameAbbreviation})";

        /// <summary>Gets the english abbreviation.</summary>
        /// <value>The english abbreviation.</value>
        public string EnglishAbbreviation => EnglishName.Substring(0, 3);
    }
}
