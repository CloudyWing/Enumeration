using System;

namespace CloudyWing.Enumeration {
    /// <summary>The when statement.</summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="ISwitchStatement{TEnum, TValue}">IEnumeration&lt;TEnum, TValue&gt;</seealso>
    /// <seealso cref="IEnumeration{TEnum, TValue}">IEnumeration&lt;TEnum, TValue&gt;</seealso>
    public interface IWhenStatement<TEnum, TValue> : ISwitchStatement<TEnum, TValue>
        where TEnum : IEnumeration<TEnum, TValue>
        where TValue : IComparable {
        /// <summary>Gets the match predicate.</summary>
        /// <value>The match predicate.</value>
        Func<bool> MatchPredicate { get; }

        /// <summary>Thens the specified action.</summary>
        /// <param name="action">The action.</param>
        /// <returns>The <c>IThenEnumeration</c>.</returns>
        IThenStatement<TEnum, TValue> Then(Action action);
    }
}
