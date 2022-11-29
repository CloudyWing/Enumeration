using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicGuidEnumeration2 : EnumerationBase<BasicGuidEnumeration, Guid> {
        private static readonly Lazy<BasicGuidEnumeration2> allZero = new(() => new BasicGuidEnumeration2(Guid.Empty, nameof(AllZero)));

        private static readonly Lazy<BasicGuidEnumeration2> allOne = new(() => new BasicGuidEnumeration2(Guid.Parse("11111111-1111-1111-1111-111111111111"), nameof(AllOne)));
        private static readonly Lazy<BasicGuidEnumeration2> allTwo = new(() => new BasicGuidEnumeration2(Guid.Parse("22222222-2222-2222-2222-111111111111"), nameof(AllTwo)));

        private BasicGuidEnumeration2(Guid value, string name) : base(value, name) { }

        public static BasicGuidEnumeration2 AllZero => allZero.Value;

        public static BasicGuidEnumeration2 AllOne => allOne.Value;

        public static BasicGuidEnumeration2 AllTwo => allTwo.Value;
    }
}
