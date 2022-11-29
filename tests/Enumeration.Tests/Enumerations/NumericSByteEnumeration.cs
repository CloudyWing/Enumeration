using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericSByteEnumeration : SByteEnumeration<NumericSByteEnumeration> {
        private NumericSByteEnumeration(sbyte value) : base(value) { }

        public static NumericSByteEnumeration One { get; } = new NumericSByteEnumeration(1);
    }
}
