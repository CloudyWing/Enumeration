using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericByteEnumeration : ByteEnumeration<NumericByteEnumeration> {
        private NumericByteEnumeration(byte value) : base(value) { }

        public static NumericByteEnumeration One { get; } = new NumericByteEnumeration(1);
    }
}
