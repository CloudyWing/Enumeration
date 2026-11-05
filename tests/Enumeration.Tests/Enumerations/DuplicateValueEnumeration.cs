using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class DuplicateValueEnumeration : ConvertibleEnumeration<DuplicateValueEnumeration, int> {
        private DuplicateValueEnumeration(int value, string name) : base(value, name) { }

        public static DuplicateValueEnumeration Red { get; } = new DuplicateValueEnumeration(1, nameof(Red));

        public static DuplicateValueEnumeration Crimson { get; } = new DuplicateValueEnumeration(1, nameof(Crimson));

        public static DuplicateValueEnumeration Green { get; } = new DuplicateValueEnumeration(2, nameof(Green));

        public static DuplicateValueEnumeration Lime { get; } = new DuplicateValueEnumeration(3, "green");
    }
}
