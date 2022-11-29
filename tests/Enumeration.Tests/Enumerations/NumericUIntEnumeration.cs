using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericUIntEnumeration : UIntEnumeration<NumericUIntEnumeration> {
        private NumericUIntEnumeration(uint value) : base(value) { }

        public static NumericUIntEnumeration One { get; } = new NumericUIntEnumeration(1U);
    }
}
