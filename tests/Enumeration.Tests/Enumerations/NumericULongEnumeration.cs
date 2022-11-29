using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericULongEnumeration : ULongEnumeration<NumericULongEnumeration> {
        private NumericULongEnumeration(ulong value) : base(value) { }

        public static NumericULongEnumeration One { get; } = new NumericULongEnumeration(1UL);
    }
}
