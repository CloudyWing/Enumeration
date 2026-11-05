using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class OrderKeyEnumeration : EnumerationBase<OrderKeyEnumeration, CaseInsensitiveOrderKey> {
        private OrderKeyEnumeration(string key, string name) : base(new CaseInsensitiveOrderKey(key), name) { }

        public static OrderKeyEnumeration Upper { get; } = new OrderKeyEnumeration("A", nameof(Upper));

        public static OrderKeyEnumeration Lower { get; } = new OrderKeyEnumeration("a", nameof(Lower));
    }
}
