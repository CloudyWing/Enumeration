using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicIntEnumeration2 : ConvertibleEnumeration<BasicIntEnumeration2, int> {
        private BasicIntEnumeration2(int value, string name) : base(value, name) { }

        public static BasicIntEnumeration2 Zero { get; set; } = new BasicIntEnumeration2(0, nameof(Zero));

        public static BasicIntEnumeration2 One { get; set; } = new BasicIntEnumeration2(1, nameof(One));

        public static BasicIntEnumeration2 Two { get; set; } = new BasicIntEnumeration2(2, nameof(Two));
    }
}
