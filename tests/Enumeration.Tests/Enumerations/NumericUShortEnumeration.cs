using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericUShortEnumeration : UShortEnumeration<NumericUShortEnumeration> {
        private NumericUShortEnumeration(ushort value) : base(value) { }

        public static NumericUShortEnumeration One { get; } = new NumericUShortEnumeration(1);
    }
}
