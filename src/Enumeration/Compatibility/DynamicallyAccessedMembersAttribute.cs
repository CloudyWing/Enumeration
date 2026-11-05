#if !NET5_0_OR_GREATER
namespace System.Diagnostics.CodeAnalysis {
    [AttributeUsage(
        AttributeTargets.Field | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.Parameter
            | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface
            | AttributeTargets.Struct,
        Inherited = false
    )]
    internal sealed class DynamicallyAccessedMembersAttribute : Attribute {
        public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes) {
            MemberTypes = memberTypes;
        }

        public DynamicallyAccessedMemberTypes MemberTypes { get; }
    }

    [Flags]
    internal enum DynamicallyAccessedMemberTypes {
        None = 0,
        PublicProperties = 0x0200,
        Interfaces = 0x2000
    }
}
#endif
