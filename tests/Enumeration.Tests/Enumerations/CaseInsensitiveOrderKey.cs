namespace CloudyWing.Enumeration.Tests.Enumerations {
    /// <summary>
    /// 排序時忽略大小寫、相等判斷時區分大小寫的測試用值型別。
    /// </summary>
    internal readonly struct CaseInsensitiveOrderKey : IComparable, IEquatable<CaseInsensitiveOrderKey> {
        public CaseInsensitiveOrderKey(string text) {
            Text = text;
        }

        public string Text { get; }

        public int CompareTo(object? obj) {
            return obj is CaseInsensitiveOrderKey other
                ? string.Compare(Text, other.Text, StringComparison.OrdinalIgnoreCase)
                : 1;
        }

        public bool Equals(CaseInsensitiveOrderKey other) {
            return string.Equals(Text, other.Text, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj) {
            return obj is CaseInsensitiveOrderKey other && Equals(other);
        }

        public override int GetHashCode() {
            return StringComparer.Ordinal.GetHashCode(Text);
        }

        public override string ToString() {
            return Text;
        }
    }
}
