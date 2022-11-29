using System;

namespace CloudyWing.Enumeration {
    /// <summary>The then statement.</summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="ISwitchStatement{TEnum, TValue}">IEnumeration&lt;TEnum, TValue&gt;</seealso>
    /// <seealso cref="IEnumeration{TEnum, TValue}">IEnumeration&lt;TEnum, TValue&gt;</seealso>
    public interface IThenStatement<TEnum, TValue> : ISwitchStatement<TEnum, TValue>
        where TEnum : IEnumeration<TEnum, TValue>
        where TValue : IComparable {
        /// <summary>Gets a value indicating whether this action is executed.</summary>
        /// <value>
        ///   <c>true</c> if this action is executed; otherwise, <c>false</c>.</value>
        bool IsExecuted { get; }

        /// <summary>Defaults the specified action.</summary>
        /// <param name="action">The action.</param>
        void Default(Action action);
    }
}
