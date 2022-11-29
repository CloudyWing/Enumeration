using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class BasicGuidEnumeration : EnumerationBase<BasicGuidEnumeration, Guid> {
        private static readonly Lazy<BasicGuidEnumeration> allZero = new(() => new BasicGuidEnumeration(Guid.Empty, nameof(AllZero)));

        private static readonly Lazy<BasicGuidEnumeration> allOne = new(() => new BasicGuidEnumeration(Guid.Parse("11111111-1111-1111-1111-111111111111"), nameof(AllOne)));
        private static readonly Lazy<BasicGuidEnumeration> allTwo = new(() => new BasicGuidEnumeration(Guid.Parse("22222222-2222-2222-2222-111111111111"), nameof(AllTwo)));

        private BasicGuidEnumeration(Guid value, string name) : base(value, name) { }

        public static BasicGuidEnumeration AllZero => allZero.Value;

        public static BasicGuidEnumeration AllOne => allOne.Value;

        public static BasicGuidEnumeration AllTwo => allTwo.Value;
    }
}
