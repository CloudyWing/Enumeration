using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NumericIntEnumeration : IntEnumeration<NumericIntEnumeration> {
        private NumericIntEnumeration(int value) : base(value) { }

        public static NumericIntEnumeration One { get; } = new NumericIntEnumeration(1);
    }
    internal class NumberIntEnumeration2 : IntEnumeration<NumberIntEnumeration2> {
        private NumberIntEnumeration2(int value) : base(value) { }

        public static NumberIntEnumeration2 One { get; } = new NumberIntEnumeration2(1);
    }
}
