using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicStringEnumeration2 : ConvertibleEnumeration<BasicStringEnumeration2, string> {
        private BasicStringEnumeration2(string value, string name) : base(value, name) { }

        public static BasicStringEnumeration2 Zero { get; set; } = new BasicStringEnumeration2("0", nameof(Zero));

        public static BasicStringEnumeration2 One { get; set; } = new BasicStringEnumeration2("1", nameof(One));

        public static BasicStringEnumeration2 Two { get; set; } = new BasicStringEnumeration2("2", nameof(Two));
    }
}
