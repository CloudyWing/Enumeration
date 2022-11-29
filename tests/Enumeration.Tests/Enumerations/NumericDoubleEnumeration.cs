using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericDoubleEnumeration : DoubleEnumeration<NumericDoubleEnumeration> {
        private NumericDoubleEnumeration(double value) : base(value) { }

        public static NumericDoubleEnumeration One { get; } = new NumericDoubleEnumeration(1D);
    }
}
