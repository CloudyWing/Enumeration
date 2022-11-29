using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicStringEnumeration : ConvertibleEnumeration<BasicStringEnumeration, string> {
        private BasicStringEnumeration(string value, string name) : base(value, name) { }

        public static BasicStringEnumeration Zero { get; set; } = new BasicStringEnumeration("0", nameof(Zero));

        public static BasicStringEnumeration One { get; set; } = new BasicStringEnumeration("1", nameof(One));

        public static BasicStringEnumeration Two { get; set; } = new BasicStringEnumeration("2", nameof(Two));
    }
}
