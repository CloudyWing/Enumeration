using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicIntEnumeration : ConvertibleEnumeration<BasicIntEnumeration, int> {
        private BasicIntEnumeration(int value, string name) : base(value, name) { }

        public static BasicIntEnumeration Zero { get; set; } = new BasicIntEnumeration(0, nameof(Zero));

        public static BasicIntEnumeration One { get; set; } = new BasicIntEnumeration(1, nameof(One));

        public static BasicIntEnumeration Two { get; set; } = new BasicIntEnumeration(2, nameof(Two));
    }
}
