using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericCharEnumeration : CharEnumeration<NumericCharEnumeration> {
        private NumericCharEnumeration(char value) : base(value) { }

        public static NumericCharEnumeration One { get; } = new NumericCharEnumeration((char)1);
    }
}
