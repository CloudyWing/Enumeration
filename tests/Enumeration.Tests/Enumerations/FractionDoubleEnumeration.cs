using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class FractionDoubleEnumeration : DoubleEnumeration<FractionDoubleEnumeration> {
        private FractionDoubleEnumeration(double value, string name) : base(value, name) { }

        public static FractionDoubleEnumeration Half { get; } = new FractionDoubleEnumeration(0.5D, nameof(Half));

        public static FractionDoubleEnumeration NotANumber { get; } = new FractionDoubleEnumeration(double.NaN, nameof(NotANumber));
    }
}
