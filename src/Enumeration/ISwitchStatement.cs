using System;

namespace CloudyWing.Enumeration {
    /// <summary>The switch statement interface</summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface ISwitchStatement<TEnum, TValue>
        where TEnum : IEnumeration<TEnum, TValue>
        where TValue : IComparable {
        /// <summary>Gets the inner statement.</summary>
        /// <value>The inner statement.</value>
        ISwitchStatement<TEnum, TValue> InnerStatement { get; }

        /// <summary>Gets the enumeration.</summary>
        /// <value>The enumeration.</value>
        IEnumeration<TEnum, TValue> Enumeration { get; }
    }
}
