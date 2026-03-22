using System.Collections.Concurrent;
using CloudyWing.Enumeration.Abstractions;
using CloudyWing.Enumeration.Tests.Enumerations;
using Microsoft.CSharp.RuntimeBinder;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal partial class NumericEnumerationTests {
        private static readonly ConcurrentDictionary<Type, ConcurrentBag<Type>> equalThrowMaps = new() {
            [typeof(sbyte)] = new ConcurrentBag<Type> { typeof(ulong) },
            [typeof(short)] = new ConcurrentBag<Type> { typeof(ulong) },
            [typeof(int)] = new ConcurrentBag<Type> { typeof(ulong) },
            [typeof(long)] = new ConcurrentBag<Type> { typeof(ulong) },
            [typeof(ulong)] = new ConcurrentBag<Type> { typeof(sbyte), typeof(short), typeof(int), typeof(long) },
            [typeof(float)] = new ConcurrentBag<Type> { typeof(decimal) },
            [typeof(double)] = new ConcurrentBag<Type> { typeof(decimal) },
            [typeof(decimal)] = new ConcurrentBag<Type> { typeof(float), typeof(double) },
        };

        private static readonly IEnumerable<object[]> conversionTestSource = new object[][] {
            new object[] { NumericByteEnumeration.One, NumericByteEnumeration.One.Value },
            new object[] { NumericSByteEnumeration.One, NumericSByteEnumeration.One.Value },
            new object[] { NumericShortEnumeration.One , NumericShortEnumeration.One.Value },
            new object[] { NumericUShortEnumeration.One , NumericUShortEnumeration.One.Value },
            new object[] { NumericIntEnumeration.One , NumericIntEnumeration.One.Value },
            new object[] { NumericUIntEnumeration.One , NumericUIntEnumeration.One.Value },
            new object[] { NumericLongEnumeration.One , NumericLongEnumeration.One.Value },
            new object[] { NumericULongEnumeration.One , NumericULongEnumeration.One.Value },
            new object[] { NumericFloatEnumeration.One , NumericFloatEnumeration.One.Value },
            new object[] { NumericDoubleEnumeration.One , NumericDoubleEnumeration.One.Value },
            new object[] { NumericDecimalEnumeration.One , NumericDecimalEnumeration.One.Value }
        };

        private static readonly dynamic[] numbers = new dynamic[] {
            (char)1, (byte)1, (sbyte)1, (short)1, (ushort)1, 1, 1U, 1L, 1UL, 1F, 1D, 1M
        };

        [Test]
        public void Equals_CharEnumerationComparedWithNumber_MatchesUnderlyingValueEquality() {
            // CharEnumeration cannot be used in TestCase, so this scenario is covered separately.
            foreach (dynamic num in numbers) {
                bool actual = NumericCharEnumeration.One.Equals(num);

                bool expected = NumericCharEnumeration.One.Equals(num);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void Equals_EnumerationComparedWithNumber_MatchesUnderlyingValueEquality<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            // TValue must be passed to enable the test case because it cannot be inferred otherwise.
            foreach (dynamic num in numbers) {
                bool actual = enumeration.Equals(num);

                bool expected = value.Equals(num);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void EqualityOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueEquality() {
            // CharEnumeration cannot be used in TestCase, so this scenario is covered separately.
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value == num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One == num;

                bool expected = NumericCharEnumeration.One.Value == num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void EqualityOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueEquality<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value == num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration == num;

                bool expected = value == num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }


        [Test]
        public void EqualityOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueEquality() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num == NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num == NumericCharEnumeration.One;

                bool expected = num == NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }


        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void EqualityOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueEquality<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num == value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num == enumeration;

                bool expected = num == value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void InequalityOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueInequality() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value != num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One != num;

                bool expected = NumericCharEnumeration.One.Value != num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void InequalityOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueInequality<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value != num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration != num;

                bool expected = value != num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void InequalityOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueInequality() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num != NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num != NumericCharEnumeration.One;

                bool expected = num != NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void InequalityOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueInequality<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num != value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num != enumeration;

                bool expected = num != value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void GreaterThanOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One > num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One > num;

                bool expected = NumericCharEnumeration.One.Value > num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterThanOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value > num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration > num;

                bool expected = value > num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void GreaterThanOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num > NumericCharEnumeration.One;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num > NumericCharEnumeration.One;

                bool expected = num > NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterThanOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num > value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num > enumeration;

                bool expected = num > value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void LessThanOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value < num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One < num;

                bool expected = NumericCharEnumeration.One.Value < num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessThanOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value < num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration < num;

                bool expected = value < num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void LessThanOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num < NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num < NumericCharEnumeration.One;

                bool expected = num < NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessThanOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num < value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num < enumeration;

                bool expected = num < value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void GreaterThanOrEqualOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value >= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One >= num;

                bool expected = NumericCharEnumeration.One.Value >= num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterThanOrEqualOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value >= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration >= num;

                bool expected = value >= num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void GreaterThanOrEqualOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num >= NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num >= NumericCharEnumeration.One;

                bool expected = num >= NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterThanOrEqualOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num >= value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num >= enumeration;

                bool expected = num >= value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void LessThanOrEqualOperator_CharEnumerationComparedWithNumber_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value <= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = NumericCharEnumeration.One <= num;

                bool expected = NumericCharEnumeration.One.Value <= num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessThanOrEqualOperator_EnumerationComparedWithNumber_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value <= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = enumeration <= num;

                bool expected = value <= num;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void LessThanOrEqualOperator_NumberComparedWithCharEnumeration_MatchesUnderlyingValueComparison() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num <= NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num <= NumericCharEnumeration.One;

                bool expected = num <= NumericCharEnumeration.One.Value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessThanOrEqualOperator_NumberComparedWithEnumeration_MatchesUnderlyingValueComparison<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num <= value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actual = num <= enumeration;

                bool expected = num <= value;
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
