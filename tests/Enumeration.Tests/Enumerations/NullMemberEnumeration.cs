using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class NullableMemberEnumeration : ConvertibleEnumeration<NullableMemberEnumeration, int> {
        private NullableMemberEnumeration(int value, string name) : base(value, name) { }

        public static NullableMemberEnumeration One { get; } = new NullableMemberEnumeration(1, nameof(One));

        public static NullableMemberEnumeration? None => null;

        public static string? Description => null;
    }

    internal class NullMemberEnumeration : ConvertibleEnumeration<NullMemberEnumeration, int> {
        private NullMemberEnumeration(int value, string name) : base(value, name) { }

        public static NullMemberEnumeration One { get; } = new NullMemberEnumeration(1, nameof(One));

        public static NullMemberEnumeration Missing => null!;
    }

    internal class ConcurrentInitializationEnumeration : ConvertibleEnumeration<ConcurrentInitializationEnumeration, int> {
        private ConcurrentInitializationEnumeration(int value, string name) : base(value, name) { }

        public static ConcurrentInitializationEnumeration One { get; } = new ConcurrentInitializationEnumeration(1, nameof(One));

        public static ConcurrentInitializationEnumeration Two { get; } = new ConcurrentInitializationEnumeration(2, nameof(Two));

        public static ConcurrentInitializationEnumeration Three { get; } = new ConcurrentInitializationEnumeration(3, nameof(Three));
    }
}
