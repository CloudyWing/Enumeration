using System;
using System.Collections.Generic;
using System.Linq;
using CloudyWing.Enumeration;

namespace CloudyWing.Enumeration {
    /// <summary>The extension methods of enumeration.</summary>
    public static class EnumerationExtensions {
        /// <summary>Determines whether this instance is enumeration.</summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if the specified type is enumeration; otherwise, <c>false</c>.</returns>
        public static bool IsEnumeration(this Type type) {
            return GetEnumerationTypes(type).Any();
        }

        /// <summary>Gets the enumeration types.</summary>
        /// <param name="type">The type.</param>
        /// <returns>The enumeration types.</returns>
        public static IEnumerable<Type> GetEnumerationTypes(this Type type) {
            return type.GetInterfaces()
                .Union(new Type[] { type })
                .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEnumeration<,>))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>Gets the enumeration value types.</summary>
        /// <param name="type">The type.</param>
        /// <returns>The enumeration value types.</returns>
        public static IEnumerable<Type> GetEnumerationValueTypes(this Type type) {
            IEnumerable<Type> enumerationTypes = GetEnumerationTypes(type);

            foreach (Type enumeration in enumerationTypes) {
                yield return enumeration.GenericTypeArguments[1];
            }
        }

        /// <summary>Determines whether the specified value contains value.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value contains value; otherwise, <c>false</c>.</returns>
        public static bool ContainsValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations, TValue value
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Any(x => x.Value.CompareTo(value) == 0);
        }

        /// <summary>Filters the elements of an System.Collections.IEnumerable based on a value.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The <c>IEnumeration</c> based on a value.</returns>
        public static IEnumerable<TValue> OfValue<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value);
        }

        /// <summary>Filters the elements of an System.Collections.IEnumerable based on a name.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The <c>IEnumeration</c> based on a name.</returns>
        public static IEnumerable<string> OfName<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name);
        }

        /// <summary>Converts to value array.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The value array.</returns>
        public static TValue[] ToValueArray<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value).ToArray();
        }

        /// <summary>Converts to name array.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The value array.</returns>
        public static string[] ToNameArray<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name).ToArray();
        }

        /// <summary>Converts to value list.</summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The value list.</returns>
        public static IList<TValue> ToValueList<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Value).ToList();
        }

        /// <summary>Converts to name list.</summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The value list.</returns>
        public static IList<string> ToNameList<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.Select(x => x.Name).ToList();
        }

        /// <summary>Converts to dictionary.</summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="enumerations">The enumerations.</param>
        /// <returns>The pairs of value and name.</returns>
        public static IDictionary<TValue, string> ToDictionary<TEnum, TValue>(
            this IEnumerable<IEnumeration<TEnum, TValue>> enumerations
        ) where TEnum : IEnumeration<TEnum, TValue> where TValue : IComparable {
            return enumerations.ToDictionary(
                x => x.Value,
                x => x.Name
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
            return When(enumeration, matchEnumerations?.Contains(enumeration) == true);
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
            return When(statement, matchEnumerations?.Contains(statement.Enumeration) == true);
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
            return OrWhen(enumeration, matchEnumerations?.Contains(enumeration.Enumeration) == true);
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
                Enumeration = enumeration;
                MatchPredicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            }

            public ISwitchStatement<TEnum, TValue> InnerStatement { get; }

            public IEnumeration<TEnum, TValue> Enumeration { get; }

            public Func<bool> MatchPredicate { get; }

            public int CompareTo(object obj) {
                return Enumeration.CompareTo(obj);
            }

            public IThenStatement<TEnum, TValue> Then(Action action) {
                if (action is null) {
                    throw new ArgumentNullException(nameof(action));
                }

                bool isExecuted = SwitchStatementUtils.IsExecuted(this);
                bool isMatch = MatchPredicate();

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
                InnerStatement = statement;
                IsExecuted = isExecuted;
            }

            public ISwitchStatement<TEnum, TValue> InnerStatement { get; }

            public IEnumeration<TEnum, TValue> Enumeration => InnerStatement.Enumeration;

            public bool IsExecuted { get; }

            public int CompareTo(object obj) {
                throw new NotImplementedException();
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
            public static bool IsExecuted<TEnum, TValue>(ISwitchStatement<TEnum, TValue> statement)
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
