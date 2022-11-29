using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericShortEnumeration : ShortEnumeration<NumericShortEnumeration> {
        private NumericShortEnumeration(short value) : base(value) { }

        public static NumericShortEnumeration One { get; } = new NumericShortEnumeration(1);
    }
}
