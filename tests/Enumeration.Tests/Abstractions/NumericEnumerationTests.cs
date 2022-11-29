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

        private static readonly dynamic[] numbers = new dynamic[]{
            (char)1, (byte)1, (sbyte)1, (short)1, (ushort)1, 1, 1U, 1L, 1UL, 1F, 1D, 1M
        };

        [Test]
        public void Equals_CharEnumeration和Number比較() {
            // CharEnumeration 跑不進 TestCase，所以單獨寫
            foreach (dynamic num in numbers) {
                bool act = NumericCharEnumeration.One.Equals(num);
                act.Should().Be(NumericCharEnumeration.One.Equals(num));
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void Equals_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            // 要傳入 TValue，才有辦法進行 Test Case，應該是因為沒有 TValue 參數無法推論 TValue 型別
            foreach (dynamic num in numbers) {
                bool act = enumeration.Equals(num);
                act.Should().Be(value.Equals(num));
            }
        }

        [Test]
        public void EqualOperator_CharEnumeration和Number比較() {
            // CharEnumeration 跑不進 TestCase，所以單獨寫
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value == num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One == num;
                actResult.Should().Be(NumericCharEnumeration.One.Value == num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void EqualOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value == num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration == num;
                actResult.Should().Be(value == num);
            }
        }


        [Test]
        public void EqualOperator_Number和比較CharEnumeration() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num == NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num == NumericCharEnumeration.One;
                actResult.Should().Be(num == NumericCharEnumeration.One.Value);
            }
        }


        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void EqualOperator_Number和比較Enumeration<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num == value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num == enumeration;
                actResult.Should().Be(num == value);
            }
        }

        [Test]
        public void NotEqualOperator_CharEnumeration和Number比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value != num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One != num;
                actResult.Should().Be(NumericCharEnumeration.One.Value != num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void NotEqualOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value != num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration != num;
                actResult.Should().Be(value != num);
            }
        }

        [Test]
        public void NotEqualOperator_Number和CharEnumeration比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num != NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num != NumericCharEnumeration.One;
                actResult.Should().Be(num != NumericCharEnumeration.One.Value);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void NotEqualOperator_Number和Enumeration比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num != value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num != enumeration;
                actResult.Should().Be(num != value);
            }
        }

        [Test]
        public void GreaterOperator_CharEnumeration和Number比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One > num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One > num;

                actResult.Should().Be(NumericCharEnumeration.One.Value > num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value > num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration > num;

                actResult.Should().Be(value > num);
            }
        }

        [Test]
        public void GreaterOperator_Number和CharEnumeration比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num > NumericCharEnumeration.One;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num > NumericCharEnumeration.One;

                actResult.Should().Be(num > NumericCharEnumeration.One.Value);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterOperator_Number和Enumeration比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num > value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num > enumeration;

                actResult.Should().Be(num > value);
            }
        }

        [Test]
        public void LessOperator_CharEnumeration和Number比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value < num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One < num;

                actResult.Should().Be(NumericCharEnumeration.One.Value < num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value < num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration < num;

                actResult.Should().Be(value < num);
            }
        }

        [Test]
        public void LessOperator_Number和CharEnumeration比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num < NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num < NumericCharEnumeration.One;

                actResult.Should().Be(num < NumericCharEnumeration.One.Value);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessOperator_Number和Enumeration比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num < value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num < enumeration;

                actResult.Should().Be(num < value);
            }
        }

        [Test]
        public void GreaterOrEqualOperator_ChaeEnumeration和Number比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value >= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One >= num;

                actResult.Should().Be(NumericCharEnumeration.One.Value >= num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterOrEqualOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value >= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration >= num;

                actResult.Should().Be(value >= num);
            }
        }

        [Test]
        public void GreaterOrEqualOperator_Number和CharEnumeration比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num >= NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num >= NumericCharEnumeration.One;

                actResult.Should().Be(num >= NumericCharEnumeration.One.Value);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void GreaterOrEqualOperator_Number和Enumeration比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num >= value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num >= enumeration;

                actResult.Should().Be(num >= value);
            }
        }

        [Test]
        public void LessOrEqualOperator_CharEnumeration和Number比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = NumericCharEnumeration.One.Value <= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = NumericCharEnumeration.One <= num;

                actResult.Should().Be(NumericCharEnumeration.One.Value <= num);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessOrEqualOperator_Enumeration和Number比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = value <= num;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = enumeration <= num;

                actResult.Should().Be(value <= num);
            }
        }

        [Test]
        public void LessOrEqualOperator_Number和CharEnumeration比較() {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num <= NumericCharEnumeration.One.Value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num <= NumericCharEnumeration.One;

                actResult.Should().Be(num <= NumericCharEnumeration.One.Value);
            }
        }

        [Test]
        [TestCaseSource(nameof(conversionTestSource))]
        public void LessOrEqualOperator_Number和Enumeration比較<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : ConvertibleEnumeration<TEnum, TValue>
            where TValue : IComparable, IConvertible {
            foreach (dynamic num in numbers) {
                try {
                    bool assert = num <= value;
                } catch (RuntimeBinderException) {
                    continue;
                }

                bool actResult = num <= enumeration;

                actResult.Should().Be(num <= value);
            }
        }
    }
}
