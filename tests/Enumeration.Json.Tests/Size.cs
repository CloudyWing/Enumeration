using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Json.Tests {
    internal sealed class Size : EnumerationBase<Size, string> {
        private Size(string value, string name) : base(value, name) { }

        public static Size Small { get; } = new Size("S", nameof(Small));

        public static Size Large { get; } = new Size("L", nameof(Large));
    }
}
