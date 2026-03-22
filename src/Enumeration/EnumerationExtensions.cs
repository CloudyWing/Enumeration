using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using CloudyWing.Enumeration;

namespace CloudyWing.Enumeration {
    /// <summary>
    /// Provides extension methods for enumeration types and enumeration collections.
    /// </summary>
    public static class EnumerationExtensions {
        /// <summary>
        /// Determines whether the specified type implements an enumeration contract.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns><see langword="true" /> if <paramref name="type" /> implements <see cref="IEnumeration{TEnum, TValue}" />; otherwise, <see langword="false" />.</returns>
        public static bool IsEnumeration(this Type type) {
            return GetEnumerationTypes(type).Any();
        }

        /// <summary>
        /// Gets the enumeration interfaces implemented by the specified type.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns>The matching <see cref="IEnumeration{TEnum, TValue}" /> interface types.</returns>
        public static IEnumerable<Type> GetEnumerationTypes(this Type type) {
            return type.GetInterfaces()
                .Union(new Type[] { type })
                .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEnumeration<,>))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Gets the underlying value types used by the enumeration interfaces implemented by the specified type.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns>The underlying value types declared by matching enumeration interfaces.</returns>
        public static IEnumerable<Type> GetEnumerationValueTypes(this Type type) {
            IEnumerable<Type> enumerationTypes = GetEnumerationTypes(type);

            foreach (Type enumeration in enumerationTypes) {
                yield return enumeration.GenericTypeArguments[1];
            }
        }

        /// <summary>
        /// Determines whether the sequence contains an enumeration with the specified value.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to inspect.</param>
        /// <param name="value">The value to match.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        public static bool ContainsValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, TValue value
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Any(x => x.Value.CompareTo(value) == 0);
        }

        /// <summary>
        /// Determines whether the sequence contains an enumeration with the specified name.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to inspect.</param>
        /// <param name="name">The name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        public static bool ContainsName<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, string name, bool ignoreCase = false
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            StringComparison comparison = ignoreCase
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;

            return enumerations.Any(x => x.Name.Equals(name, comparison));
        }

        /// <summary>
        /// Tries to get the underlying value of the enumeration with the specified name.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to inspect.</param>
        /// <param name="name">The name to match.</param>
        /// <param name="value">The underlying value of the matching enumeration.</param>
        /// <returns><see langword="true" /> if exactly one matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one enumeration in <paramref name="enumerations" /> matches <paramref name="name" />.</exception>
        public static bool TryGetValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, string name, [MaybeNullWhen(false)] out TValue value
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return TryGetValue(enumerations, name, false, out value);
        }

        /// <summary>
        /// Tries to get the underlying value of the enumeration with the specified name.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to inspect.</param>
        /// <param name="name">The name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <param name="value">The underlying value of the matching enumeration.</param>
        /// <returns><see langword="true" /> if exactly one matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one enumeration in <paramref name="enumerations" /> matches <paramref name="name" />.</exception>
        public static bool TryGetValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, string name, bool ignoreCase, [MaybeNullWhen(false)] out TValue value
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            StringComparison comparison = ignoreCase
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;
            IEnumeration<TEnum, TValue>? enumeration = enumerations.SingleOrDefault(x => x.Name.Equals(name, comparison));

            if (enumeration is null) {
                value = default;
                return false;
            }

            value = enumeration.Value;
            return true;
        }

        /// <summary>
        /// Tries to get the name of the enumeration with the specified value.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to inspect.</param>
        /// <param name="value">The value to match.</param>
        /// <param name="name">The name of the matching enumeration.</param>
        /// <returns><see langword="true" /> if exactly one matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one enumeration in <paramref name="enumerations" /> matches <paramref name="value" />.</exception>
        public static bool TryGetName<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, TValue value, [MaybeNullWhen(false)] out string name
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            IEnumeration<TEnum, TValue>? enumeration = enumerations.SingleOrDefault(x => x.Value.CompareTo(value) == 0);

            if (enumeration is null) {
                name = default;
                return false;
            }

            name = enumeration.Name;
            return true;
        }

        /// <summary>
        /// Projects a sequence of enumerations to their underlying values.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to project.</param>
        /// <returns>The underlying values.</returns>
        public static IEnumerable<TValue> OfValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value);
        }

        /// <summary>
        /// Projects a sequence of enumerations to their names.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to project.</param>
        /// <returns>The enumeration names.</returns>
        public static IEnumerable<string> OfName<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name);
        }

        /// <summary>
        /// Materializes a sequence of enumerations as an array of underlying values.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>An array of underlying values.</returns>
        public static TValue[] ToValueArray<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value).ToArray();
        }

        /// <summary>
        /// Materializes a sequence of enumerations as an array of names.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>An array of enumeration names.</returns>
        public static string[] ToNameArray<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name).ToArray();
        }

        /// <summary>
        /// Materializes a sequence of enumerations as a list of underlying values.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>A list of underlying values.</returns>
        public static IList<TValue> ToValueList<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value).ToList();
        }

        /// <summary>
        /// Materializes a sequence of enumerations as a list of names.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>A list of enumeration names.</returns>
        public static IList<string> ToNameList<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Creates a dictionary keyed by underlying value.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>A dictionary whose keys are enumeration values and whose values are enumeration names.</returns>
        public static IDictionary<TValue, string> ToDictionary<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.ToDictionary(
                x => x.Value,
                x => x.Name
            );
        }

        /// <summary>
        /// Creates a dictionary keyed by enumeration name.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <param name="enumerations">The sequence of enumerations to convert.</param>
        /// <returns>A dictionary whose keys are enumeration names and whose values are enumeration values.</returns>
        public static IDictionary<string, TValue> ToNameValueDictionary<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.ToDictionary(
                x => x.Name,
                x => x.Value
            );
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IEnumeration<TEnum, TValue> enumeration, params IEnumeration<TEnum, TValue>[] matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return When(enumeration, matchEnumerations as IEnumerable<IEnumeration<TEnum, TValue>>);
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IEnumeration<TEnum, TValue> enumeration, IEnumerable<IEnumeration<TEnum, TValue>> matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return When(enumeration, matchEnumerations.Contains(enumeration));
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="isMatch">if set to <c>true</c> [is match].</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IEnumeration<TEnum, TValue> enumeration, bool isMatch
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            return new WhenStatement<TEnum, TValue>(enumeration, () => isMatch);
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IEnumeration<TEnum, TValue> enumeration, Func<bool> predicate
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new WhenStatement<TEnum, TValue>(enumeration, predicate);
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="statement">The then statement.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IThenStatement<TEnum, TValue> statement, params IEnumeration<TEnum, TValue>[] matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (statement is null) {
                throw new ArgumentNullException(nameof(statement));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return When(statement, matchEnumerations as IEnumerable<IEnumeration<TEnum, TValue>>);
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="statement">The then statement.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IThenStatement<TEnum, TValue> statement, IEnumerable<IEnumeration<TEnum, TValue>> matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (statement is null) {
                throw new ArgumentNullException(nameof(statement));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return When(statement, matchEnumerations.Contains(statement.Enumeration));
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="statement">The then statement.</param>
        /// <param name="isMatch">if set to <c>true</c> [is match].</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IThenStatement<TEnum, TValue> statement, bool isMatch
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (statement is null) {
                throw new ArgumentNullException(nameof(statement));
            }

            return new WhenStatement<TEnum, TValue>(statement, () => isMatch);
        }

        /// <summary>Whens the specified is match.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="statement">The then statement.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> When<TEnum, TValue>(
            this IThenStatement<TEnum, TValue> statement, Func<bool> predicate
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (statement is null) {
                throw new ArgumentNullException(nameof(statement));
            }

            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new WhenStatement<TEnum, TValue>(statement, predicate);
        }

        /// <summary>Ands the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="isMatch">if set to <c>true</c> [is match].</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> AndWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, bool isMatch
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            return AndWhen(enumeration, () => isMatch);
        }

        /// <summary>Ands the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> AndWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, Func<bool> predicate
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new WhenStatement<TEnum, TValue>(enumeration, () => enumeration.MatchPredicate() && predicate());
        }

        /// <summary>Ors the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> OrWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, params IEnumeration<TEnum, TValue>[] matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return OrWhen(enumeration, matchEnumerations as IEnumerable<IEnumeration<TEnum, TValue>>);
        }

        /// <summary>Ors the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="matchEnumerations">The match enumerations.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> OrWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, IEnumerable<IEnumeration<TEnum, TValue>> matchEnumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (matchEnumerations is null) {
                throw new ArgumentNullException(nameof(matchEnumerations));
            }

            return OrWhen(enumeration, matchEnumerations.Contains(enumeration.Enumeration));
        }

        /// <summary>Ors the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="isMatch">if set to <c>true</c> [is match].</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> OrWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, bool isMatch
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            return OrWhen(enumeration, () => isMatch);
        }

        /// <summary>Ors the when.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumeration">The enumeration.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The when statement.</returns>
        public static IWhenStatement<TEnum, TValue> OrWhen<TEnum, TValue>(
            this IWhenStatement<TEnum, TValue> enumeration, Func<bool> predicate
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            if (enumeration is null) {
                throw new ArgumentNullException(nameof(enumeration));
            }

            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new WhenStatement<TEnum, TValue>(enumeration, () => enumeration.MatchPredicate() || predicate());
        }

        private class WhenStatement<TEnum, TValue> : IWhenStatement<TEnum, TValue>
            where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            public WhenStatement(ISwitchStatement<TEnum, TValue> statement, Func<bool> predicate) {
                if (statement is null) {
                    throw new ArgumentNullException(nameof(statement));
                }

                InnerStatement = statement;
                Enumeration = statement.Enumeration;
                MatchPredicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            }

            public WhenStatement(IEnumeration<TEnum, TValue> enumeration, Func<bool> predicate) {
                if (enumeration is null) {
                    throw new ArgumentNullException(nameof(enumeration));
                }

                Enumeration = enumeration;
                MatchPredicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            }

            public ISwitchStatement<TEnum, TValue>? InnerStatement { get; }

            public IEnumeration<TEnum, TValue> Enumeration { get; }

            public Func<bool> MatchPredicate { get; }

            public int CompareTo(object? obj) {
                return Enumeration.CompareTo(obj);
            }

            public IThenStatement<TEnum, TValue> Then(Action action) {
                if (action is null) {
                    throw new ArgumentNullException(nameof(action));
                }

                bool isExecuted = SwitchStatementUtils.IsExecuted(this);

                if (MatchPredicate() && !isExecuted) {
                    isExecuted = true;
                    action();
                }

                return new ThenStatement<TEnum, TValue>(this, isExecuted);
            }
        }

        private class ThenStatement<TEnum, TValue> : IThenStatement<TEnum, TValue>
            where TEnum : IEnumeration<TEnum, TValue>
            where TValue : IComparable {
            public ThenStatement(ISwitchStatement<TEnum, TValue> statement, bool isExecuted) {
                if (statement is null) {
                    throw new ArgumentNullException(nameof(statement));
                }

                InnerStatement = statement;
                IsExecuted = isExecuted;
            }

            public ISwitchStatement<TEnum, TValue>? InnerStatement { get; }

            public IEnumeration<TEnum, TValue> Enumeration => InnerStatement!.Enumeration;

            public bool IsExecuted { get; }

            public int CompareTo(object? obj) {
                return Enumeration.CompareTo(obj);
            }

            public void Default(Action action) {
                if (action is null) {
                    throw new ArgumentNullException(nameof(action));
                }

                bool isExecuted = SwitchStatementUtils.IsExecuted(this);

                if (!isExecuted) {
                    action();
                }
            }
        }

        private static class SwitchStatementUtils {
            public static bool IsExecuted<TEnum, TValue>(ISwitchStatement<TEnum, TValue>? statement)
                where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
                bool isExecuted = false;

                while (!isExecuted && !(statement is null)) {
                    if (statement is IThenStatement<TEnum, TValue> thenStatement) {
                        isExecuted = thenStatement.IsExecuted;
                    }

                    statement = statement.InnerStatement;
                }

                return isExecuted;
            }
        }
    }
}
