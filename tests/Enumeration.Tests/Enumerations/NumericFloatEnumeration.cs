using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericFloatEnumeration : FloatEnumeration<NumericFloatEnumeration> {
        private NumericFloatEnumeration(float value) : base(value) { }

        public static NumericFloatEnumeration One { get; } = new NumericFloatEnumeration(1F);
    }
}
