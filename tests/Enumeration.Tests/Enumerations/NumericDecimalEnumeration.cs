using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericDecimalEnumeration : DecimalEnumeration<NumericDecimalEnumeration> {
        private NumericDecimalEnumeration(decimal value) : base(value) { }

        public static NumericDecimalEnumeration One { get; } = new NumericDecimalEnumeration(1M);
    }
}
