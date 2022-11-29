using System;

namespace CloudyWing.Enumeration {
    /// <summary>The enumeration interface.</summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="IComparable" />
    public interface IEnumeration<in TEnum, TValue> : IComparable where TValue : IComparable {
        /// <summary>Gets the value.</summary>
        /// <value>The value.</value>
        TValue Value { get; }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        string Name { get; }
    }
}
