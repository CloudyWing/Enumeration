using CloudyWing.Enumeration.Abstractions;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class EnumerationBaseTests {
        private readonly Guid allNine = Guid.Parse("99999999-9999-9999-9999-999999999999");

        private static readonly IEnumerable<object[]> castTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One.Value },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.One.Value },
            new object[] { BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllZero.Value }
        };

        private static readonly IEnumerable<object[]> errorCastTestSource = new object[][] {
            new object[] { 9, BasicIntEnumeration.Zero },
            new object[] {"9", BasicStringEnumeration.Zero },
            new object[] { Guid.Parse("99999999-9999-9999-9999-999999999999"), BasicGuidEnumeration.AllZero }
        };

        private static readonly IEnumerable<object[]> equalTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, true },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.One.Value, false },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, true },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.One.Value, false },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, true },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllOne.Value, false }
        };

        private static readonly IEnumerable<object[]> compareOperatorTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.Zero, BasicIntEnumeration.One.Value, true, true },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, false, true },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.One.Value, false, false },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.Zero, BasicStringEnumeration.One.Value, true, true },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, false, true },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.One.Value, false, false },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllOne.Value, true, true },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, false , true },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllOne.Value, false, false }
        };

        private static readonly IEnumerable<BasicIntEnumeration> intEnumerations = new BasicIntEnumeration[] {
            BasicIntEnumeration.Zero,
            BasicIntEnumeration.One,
            BasicIntEnumeration.Two
        };

        private static readonly IEnumerable<BasicStringEnumeration> stringEnumerations = new BasicStringEnumeration[] {
            BasicStringEnumeration.Zero,
            BasicStringEnumeration.One,
            BasicStringEnumeration.Two
        };

        private static readonly IEnumerable<BasicGuidEnumeration> guidEnumerations = new BasicGuidEnumeration[] {
            BasicGuidEnumeration.AllZero,
            BasicGuidEnumeration.AllOne,
            BasicGuidEnumeration.AllTwo
        };

        private static readonly IEnumerable<object[]> compareTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.Zero, BasicIntEnumeration.Zero.Value, 1 },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, 0 },
            new object[] { BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.Two.Value, -1 },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.Zero, BasicStringEnumeration.Zero.Value, 1 },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, 0 },
            new object[] { BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.Two.Value, -1 },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllZero.Value, 1 },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, 0 },
            new object[] { BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllTwo.Value, -1 }
        };

        [SetUp]
        public void Setup() { }

        [Test]
        [TestCaseSource(nameof(castTestSource))]
        public void ImplicitOperator<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            TValue castedValue = enumeration;
            if (value.GetType().IsValueType) {
                castedValue.Should().Be(value);
            } else {
                castedValue.Should().BeSameAs(value);
            }
        }

        [Test]
        [TestCaseSource(nameof(castTestSource))]
        public void ExplicitOperator_定義值轉換_ReturnsEnumeration<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            ((TEnum)value).Should().BeSameAs(enumeration);
        }

        [Test]
        [TestCaseSource(nameof(errorCastTestSource))]
        public void ExplicitOperator_非定義值轉換_ThrowsInvalidCastException<TEnum, TValue>(TValue value, TEnum enumeration)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            Action act = () => {
                TEnum castedEnumeration = (TEnum)value;
            };
            act.Should().Throw<InvalidCastException>();
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void EqualOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left == right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void EqualOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left == right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void EqualOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left == right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void NotEqualOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left != right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void NotEqualOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left != right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(equalTestSource))]
        public void NotEqualOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left != right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left > right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left > right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left > right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left < right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left < right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left < right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOrEqualOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left >= right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOrEqualOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left >= right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void GreaterOrEqualOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            (left >= right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOrEqualOperator_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left <= right).Should().Be(!result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOrEqualOperator_Enumeration和Value比較<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            (left <= right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareOperatorTestSource))]
        public void LessOrEqualOperator_Value和Enumeration比較<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            (left <= right).Should().Be(!result);
        }

        [Test]
        public void GetAll_IntEnumeration() {
            BasicIntEnumeration.GetAll().Should().Equal(intEnumerations);
        }

        [Test]
        public void GetAll_StringEnumeration() {
            BasicStringEnumeration.GetAll().Should().Equal(stringEnumerations);
        }

        [Test]
        public void GetAll_GuidEnumeration() {
            BasicGuidEnumeration.GetAll().Should().Equal(guidEnumerations);
        }

        [Test]
        public void Parse_IntEnumeration正確值轉換_ReturnsEnumeration() {
            BasicIntEnumeration.Parse(BasicIntEnumeration.One.Value).Should().BeSameAs(BasicIntEnumeration.One);
        }

        [Test]
        public void Parse_IntEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicIntEnumeration.Parse(9);
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        public void Parse_StringEnumeration正確值轉換_ReturnsEnumeration() {
            BasicStringEnumeration.Parse(BasicStringEnumeration.One.Value).Should().BeSameAs(BasicStringEnumeration.One);
        }

        [Test]
        public void Parse_StringEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicStringEnumeration.Parse("9");
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        public void Parse_GuidEnumeration正確值轉換_ReturnsEnumeration() {
            BasicGuidEnumeration.Parse(BasicGuidEnumeration.AllOne.Value).Should().BeSameAs(BasicGuidEnumeration.AllOne);
        }

        [Test]
        public void Parse_GuidEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicGuidEnumeration.Parse(allNine);
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        public void TryParse_IntEnumeration正確值轉換_ReturnsTrue且OutEnumeration() {
            BasicIntEnumeration.TryParse(BasicIntEnumeration.One.Value, out BasicIntEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicIntEnumeration.One);
        }

        [Test]
        public void TryParse_IntEnumeration錯誤值轉換_ReturnsFalse且OutNull() {
            BasicIntEnumeration.TryParse(9, out BasicIntEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        public void TryParse_StringEnumeration正確值轉換_ReturnsTrue且OutEnumeration() {
            BasicStringEnumeration.TryParse(BasicStringEnumeration.One.Value, out BasicStringEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicStringEnumeration.One);
        }

        [Test]
        public void TryParse_StringEnumeration錯誤值轉換_ReturnsFalse且OutNull() {
            BasicStringEnumeration.TryParse("9", out BasicStringEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        public void TryParse_GuidEnumeration正確值轉換_ReturnsTrue且OutEnumeration() {
            BasicGuidEnumeration.TryParse(BasicGuidEnumeration.AllOne.Value, out BasicGuidEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicGuidEnumeration.AllOne);
        }

        [Test]
        public void TryParse_GuidEnumeration錯誤值轉換_ReturnsFalse且OutNull() {
            BasicGuidEnumeration.TryParse(allNine, out BasicGuidEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        public void ParseName_IntEnumeration正確值轉換_ReturnsEnumeration() {
            BasicIntEnumeration.ParseName(BasicIntEnumeration.One.Name).Should().BeSameAs(BasicIntEnumeration.One);
        }

        [Test]
        public void ParseName_IntEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicIntEnumeration.ParseName("Nine");
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        public void ParseName_StringEnumeration正確值轉換_ReturnsEnumeration() {
            BasicStringEnumeration.ParseName(BasicStringEnumeration.One.Name).Should().BeSameAs(BasicStringEnumeration.One);
        }

        [Test]
        public void ParseName_StringEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicStringEnumeration.ParseName("Nine");
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        public void ParseName_GuidEnumeration正確值轉換_ReturnsEnumeration() {
            BasicGuidEnumeration.ParseName(BasicGuidEnumeration.AllOne.Name).Should().BeSameAs(BasicGuidEnumeration.AllOne);
        }

        [Test]
        public void ParseName_GuidEnumeration錯誤值轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicGuidEnumeration.ParseName("AllNine");
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void ParseName_IntEnumeration的參數Ignore測試正確轉換_ReturnsEnumeration(string name, bool ignore) {
            BasicIntEnumeration.ParseName(name, ignore).Should().BeSameAs(BasicIntEnumeration.One);
        }

        [Test]
        public void ParseName_IntEnumeration的參數Ignore測試錯誤轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicIntEnumeration.ParseName("one", false);
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void ParseName_StringEnumeration的參數Ignore測試正確轉換_ReturnsEnumeration(string name, bool ignore) {
            BasicStringEnumeration.ParseName(name, ignore).Should().BeSameAs(BasicStringEnumeration.One);
        }

        [Test]
        public void ParseName_StringEnumeration的參數Ignore測錯誤確轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicStringEnumeration.ParseName("one", false);
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        [TestCase("AllOne", false)]
        [TestCase("AllOne", true)]
        [TestCase("allone", true)]
        public void ParseName_GuidEnumeration的參數Ignore測試正確轉換_ReturnsEnumeration(string name, bool ignore) {
            BasicGuidEnumeration.ParseName(name, ignore).Should().BeSameAs(BasicGuidEnumeration.AllOne);
        }


        [Test]
        public void ParseName_GuidEnumeration的參數Ignore測試錯誤轉換_ThrowsEnumerationNotFoundException() {
            Action act = () => BasicGuidEnumeration.ParseName("allone", false);
            act.Should().Throw<EnumerationNotFoundException>();
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void TryParseName_IntEnumeration的參數Ignore測試正確轉換_ReturnsTrue且OutEnumeration(string name, bool ignore) {
            BasicIntEnumeration.TryParseName(name, ignore, out BasicIntEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicIntEnumeration.One);
        }

        [Test]
        public void TryParseName_IntEnumeration的參數Ignore測試錯誤轉換_ReturnsFalse且OutNull() {
            BasicIntEnumeration.TryParseName("one", false, out BasicIntEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void TryParseName_StringEnumeration的參數Ignore測試正確轉換_ReturnsTrue且OutEnumeration(string name, bool ignore) {
            BasicStringEnumeration.TryParseName(name, ignore, out BasicStringEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicStringEnumeration.One);
        }

        [Test]
        public void TryParseName_StringEnumeration的參數Ignore測試錯誤轉換_ReturnsFalse且OutNull() {
            BasicStringEnumeration.TryParseName("one", false, out BasicStringEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        [TestCase("AllOne", false)]
        [TestCase("AllOne", true)]
        [TestCase("allone", true)]
        public void TryParseName_GuidEnumeration的參數Ignore測試正確轉換_ReturnsTrue且OutEnumeration(string name, bool ignore) {
            BasicGuidEnumeration.TryParseName(name, ignore, out BasicGuidEnumeration enumeration).Should().BeTrue();
            enumeration.Should().BeSameAs(BasicGuidEnumeration.AllOne);
        }

        [Test]
        public void TryParseName_GuidEnumeration的參數Ignore測試錯誤轉換_ReturnsFalse且OutNull() {
            BasicGuidEnumeration.TryParseName("allone", false, out BasicGuidEnumeration enumeration).Should().BeFalse();
            enumeration.Should().BeNull();
        }

        [Test]
        public void GetValueType_ReturnsValueType() {
            BasicIntEnumeration.GetValueType().Should().BeSameAs(typeof(int));
            BasicStringEnumeration.GetValueType().Should().BeSameAs(typeof(string));
            BasicGuidEnumeration.GetValueType().Should().BeSameAs(typeof(Guid));
        }
        [Test]
        public void Equals_IntEnumeration和IntEnumeration比較() {
            BasicIntEnumeration.One.Equals(BasicIntEnumeration.One).Should().BeTrue();
            BasicIntEnumeration.One.Equals(BasicIntEnumeration.Two).Should().BeFalse();
        }

        [Test]
        public void Equals_IntEnumeration和OtherEnumeration比較_ReturnsFalse() {
            BasicIntEnumeration.One.Equals(BasicIntEnumeration2.One).Should().BeFalse();
            BasicIntEnumeration.One.Equals(BasicStringEnumeration.One).Should().BeFalse();
        }

        [Test]
        public void Equals_StringEnumeration和StringEnumeration比較() {
            BasicStringEnumeration.One.Equals(BasicStringEnumeration.One).Should().BeTrue();
            BasicStringEnumeration.One.Equals(BasicStringEnumeration.Two).Should().BeFalse();
        }

        [Test]
        public void Equals_StringEnumeration和OtherEnumeration比較_ReturnsFalse() {
            BasicStringEnumeration.One.Equals(BasicStringEnumeration2.One).Should().BeFalse();
            BasicStringEnumeration.One.Equals(BasicIntEnumeration.One).Should().BeFalse();
        }

        [Test]
        public void Equals_GuidEnumeration和GuidEnumeration比較() {
            BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration.AllOne).Should().BeTrue();
            BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration.AllTwo).Should().BeFalse();
        }

        [Test]
        public void Equals_GuidEnumeration和OtherEnumeration比較_ReturnsFalse() {
            BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration2.AllOne).Should().BeFalse();
            BasicGuidEnumeration.AllOne.Equals(BasicIntEnumeration.One).Should().BeFalse();
        }

        [Test]
        [TestCaseSource(nameof(compareTestSource))]
        public void CompareTo_Enumeration和Enumeration比較<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, int result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            left.CompareTo(right).Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(compareTestSource))]
        public void CompareTo_Enumeration和Value比較<TEnum, TValue>(TEnum left, TEnum ignore, TValue right, int result)
            where TEnum : EnumerationBase<TEnum, TValue> where TValue : IComparable {
            left.CompareTo(right).Should().Be(result);
        }
    }
}
