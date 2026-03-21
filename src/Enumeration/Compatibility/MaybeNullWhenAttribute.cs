#if NET45 || NETSTANDARD2_0
using System;

namespace System.Diagnostics.CodeAnalysis {
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class MaybeNullWhenAttribute : Attribute {
        public MaybeNullWhenAttribute(bool returnValue) {
            ReturnValue = returnValue;
        }

        public bool ReturnValue { get; }
    }
}
#endif
