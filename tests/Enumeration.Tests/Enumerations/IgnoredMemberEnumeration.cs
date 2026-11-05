using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class IgnoredMemberEnumeration : ConvertibleEnumeration<IgnoredMemberEnumeration, int> {
        private IgnoredMemberEnumeration(int value, string name) : base(value, name) { }

        public static IgnoredMemberEnumeration One { get; } = new IgnoredMemberEnumeration(1, nameof(One));

        [EnumerationIgnore]
        public static IgnoredMemberEnumeration Helper { get; } = new IgnoredMemberEnumeration(1, nameof(Helper));

        [EnumerationIgnore]
        public static IgnoredMemberEnumeration Throwing => throw new InvalidOperationException("The getter must not be invoked.");

        [EnumerationIgnore]
        public static IgnoredMemberEnumeration Missing => null!;

        public static IgnoredMemberEnumeration Two { get; } = new IgnoredMemberEnumeration(2, nameof(Two));
    }
}
