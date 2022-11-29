using System;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Calendars {
    /// <summary>The month enumeration.</summary>
    /// <seealso cref="IntEnumeration&lt;Month&gt;" />
    [Serializable]
    public sealed class Month : IntEnumeration<Month> {
        private static readonly Lazy<Month> january = new Lazy<Month>(() => new Month(1, "一月", nameof(January)));
        private static readonly Lazy<Month> february = new Lazy<Month>(() => new Month(2, "二月", nameof(February)));
        private static readonly Lazy<Month> march = new Lazy<Month>(() => new Month(3, "三月", nameof(March)));
        private static readonly Lazy<Month> april = new Lazy<Month>(() => new Month(4, "四月", nameof(April)));
        private static readonly Lazy<Month> may = new Lazy<Month>(() => new Month(5, "五月", nameof(May)));
        private static readonly Lazy<Month> june = new Lazy<Month>(() => new Month(6, "六月", nameof(June)));
        private static readonly Lazy<Month> july = new Lazy<Month>(() => new Month(7, "七月", nameof(July)));
        private static readonly Lazy<Month> august = new Lazy<Month>(() => new Month(8, "八月", nameof(August)));
        private static readonly Lazy<Month> september = new Lazy<Month>(() => new Month(9, "九月", nameof(September)));
        private static readonly Lazy<Month> october = new Lazy<Month>(() => new Month(10, "十月", nameof(October)));
        private static readonly Lazy<Month> november = new Lazy<Month>(() => new Month(11, "十一月", nameof(November)));
        private static readonly Lazy<Month> december = new Lazy<Month>(() => new Month(12, "十二月", nameof(December)));

        private Month(int value, string name, string englishName) : base(value, name) {
            EnglishName = englishName;
        }

        /// <summary>Implements the operator +.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static Month operator +(Month left, int right) {
            int remainder = ((left.Value + right - 1) % 12) + 1;
            return (Month)(remainder < 1 ? remainder + 12 : remainder);
        }


        /// <summary>Implements the operator -.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static Month operator -(Month left, int right) {
            return left + (0 - right);
        }

        /// <summary>Implements the operator ++.</summary>
        /// <param name="month">The month.</param>
        /// <returns>The result of the operator.</returns>
        public static Month operator ++(Month month) {
            return month + 1;
        }

        /// <summary>Implements the operator --.</summary>
        /// <param name="month">The month.</param>
        /// <returns>The result of the operator.</returns>
        public static Month operator --(Month month) {
            return month - 1;
        }

        /// <summary>Gets the january.</summary>
        /// <value>The january.</value>
        public static Month January => january.Value;

        /// <summary>Gets the february.</summary>
        /// <value>The february.</value>
        public static Month February => february.Value;

        /// <summary>Gets the march.</summary>
        /// <value>The march.</value>
        public static Month March => march.Value;

        /// <summary>Gets the april.</summary>
        /// <value>The april.</value>
        public static Month April => april.Value;

        /// <summary>Gets the may.</summary>
        /// <value>The may.</value>
        public static Month May => may.Value;

        /// <summary>Gets the june.</summary>
        /// <value>The june.</value>
        public static Month June => june.Value;

        /// <summary>Gets the july.</summary>
        /// <value>The july.</value>
        public static Month July => july.Value;

        /// <summary>Gets the august.</summary>
        /// <value>The august.</value>
        public static Month August => august.Value;

        /// <summary>Gets the september.</summary>
        /// <value>The september.</value>
        public static Month September => september.Value;

        /// <summary>Gets the october.</summary>
        /// <value>The october.</value>
        public static Month October => october.Value;

        /// <summary>Gets the november.</summary>
        /// <value>The november.</value>
        public static Month November => november.Value;

        /// <summary>Gets the december.</summary>
        /// <value>The december.</value>
        public static Month December => december.Value;

        /// <summary>Gets the name of the english.</summary>
        /// <value>The name of the english.</value>
        public string EnglishName { get; }

        /// <summary>Gets the name abbreviation.</summary>
        /// <value>The name abbreviation.</value>
        public string NameAbbreviation => Name.Substring(0, Name.Length - 1);

        /// <summary>Gets the english abbreviation.</summary>
        /// <value>The english abbreviation.</value>
        public string EnglishAbbreviation => EnglishName.Substring(0, 3);
    }
}
