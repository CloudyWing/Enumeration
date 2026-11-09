using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Json.Tests {
    internal sealed class Color : EnumerationBase<Color, int> {
        private Color(int value, string name) : base(value, name) { }

        public static Color Red { get; } = new Color(1, nameof(Red));

        public static Color Green { get; } = new Color(2, nameof(Green));
    }
}
