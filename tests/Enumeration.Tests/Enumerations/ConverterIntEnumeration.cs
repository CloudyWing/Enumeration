using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class ConverterIntEnumeration : ConvertibleEnumeration<ConverterIntEnumeration, int> {
        private ConverterIntEnumeration(int value, string name) : base(value, name) { }

        public static ConverterIntEnumeration Active { get; } = new ConverterIntEnumeration(1, nameof(Active));

        public static ConverterIntEnumeration Inactive { get; } = new ConverterIntEnumeration(2, nameof(Inactive));
    }
}
