using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class AliasIntEnumeration : ConvertibleEnumeration<AliasIntEnumeration, int> {
        private AliasIntEnumeration(int value, string name) : base(value, name) { }

        public static AliasIntEnumeration Red { get; } = new AliasIntEnumeration(1, nameof(Red));

        public static AliasIntEnumeration Green { get; } = new AliasIntEnumeration(2, nameof(Green));

        public static AliasIntEnumeration Default => Red;

        public static AliasIntEnumeration Blue { get; } = new AliasIntEnumeration(3, nameof(Blue));

        public static AliasIntEnumeration WriteOnly {
            set { }
        }
    }
}
