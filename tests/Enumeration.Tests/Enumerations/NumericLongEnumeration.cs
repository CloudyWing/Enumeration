using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericLongEnumeration : LongEnumeration<NumericLongEnumeration> {
        private NumericLongEnumeration(long value) : base(value) { }

        public static NumericLongEnumeration One { get; } = new NumericLongEnumeration(1L);
    }
}
