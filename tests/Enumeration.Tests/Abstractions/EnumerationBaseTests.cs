using CloudyWing.Enumeration.Abstractions;
using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class EnumerationBaseTests {
        private readonly Guid allNine = Guid.Parse("99999999-9999-9999-9999-999999999999");

        private static readonly IEnumerable<object[]> CastTestSource = [
            [BasicIntEnumeration.One, BasicIntEnumeration.One.Value],
            [BasicStringEnumeration.One, BasicStringEnumeration.One.Value],
            [BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllZero.Value]
        ];

        private static readonly IEnumerable<object[]> ErrorCastTestSource = [
            [9, BasicIntEnumeration.Zero],
            ["9", BasicStringEnumeration.Zero],
            [Guid.Parse("99999999-9999-9999-9999-999999999999"), BasicGuidEnumeration.AllZero]
        ];

        private static readonly IEnumerable<object[]> EqualTestSource = [
            [BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, true],
            [BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.One.Value, false],
            [BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, true],
            [BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.One.Value, false],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, true],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllOne.Value, false]
        ];

        private static readonly IEnumerable<object[]> CompareOperatorTestSource = [
            [BasicIntEnumeration.One, BasicIntEnumeration.Zero, BasicIntEnumeration.One.Value, true, true],
            [BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, false, true],
            [BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.One.Value, false, false],
            [BasicStringEnumeration.One, BasicStringEnumeration.Zero, BasicStringEnumeration.One.Value, true, true],
            [BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, false, true],
            [BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.One.Value, false, false],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllOne.Value, true, true],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, false, true],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllOne.Value, false, false]
        ];

        private static readonly IEnumerable<BasicIntEnumeration> IntEnumerations = [
            BasicIntEnumeration.Zero,
            BasicIntEnumeration.One,
            BasicIntEnumeration.Two
        ];

        private static readonly IEnumerable<BasicStringEnumeration> StringEnumerations = [
            BasicStringEnumeration.Zero,
            BasicStringEnumeration.One,
            BasicStringEnumeration.Two
        ];

        private static readonly IEnumerable<BasicGuidEnumeration> GuidEnumerations = [
            BasicGuidEnumeration.AllZero,
            BasicGuidEnumeration.AllOne,
            BasicGuidEnumeration.AllTwo
        ];

        private static readonly IEnumerable<object[]> CompareTestSource = [
            [BasicIntEnumeration.One, BasicIntEnumeration.Zero, BasicIntEnumeration.Zero.Value, 1],
            [BasicIntEnumeration.One, BasicIntEnumeration.One, BasicIntEnumeration.One.Value, 0],
            [BasicIntEnumeration.One, BasicIntEnumeration.Two, BasicIntEnumeration.Two.Value, -1],
            [BasicStringEnumeration.One, BasicStringEnumeration.Zero, BasicStringEnumeration.Zero.Value, 1],
            [BasicStringEnumeration.One, BasicStringEnumeration.One, BasicStringEnumeration.One.Value, 0],
            [BasicStringEnumeration.One, BasicStringEnumeration.Two, BasicStringEnumeration.Two.Value, -1],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllZero, BasicGuidEnumeration.AllZero.Value, 1],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllOne.Value, 0],
            [BasicGuidEnumeration.AllOne, BasicGuidEnumeration.AllTwo, BasicGuidEnumeration.AllTwo.Value, -1]
        ];

        [SetUp]
        public void Setup() { }

        [Test]
        [TestCaseSource(nameof(CastTestSource))]
        public void ImplicitOperator_EnumerationProvided_ReturnsValue<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            TValue actual = enumeration;

            if (value.GetType().IsValueType) {
                Assert.That(actual, Is.EqualTo(value));
            } else {
                Assert.That(actual, Is.SameAs(value));
            }
        }

        [Test]
        [TestCaseSource(nameof(CastTestSource))]
        public void ExplicitOperator_DefinedValueProvided_ReturnsEnumeration<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            TEnum actual = (TEnum)value;

            Assert.That(actual, Is.SameAs(enumeration));
        }

        [Test]
        [TestCaseSource(nameof(ErrorCastTestSource))]
        public void ExplicitOperator_UndefinedValueProvided_ThrowsInvalidCastException<TEnum, TValue>(TValue value, TEnum enumeration)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {

            Assert.Throws<InvalidCastException>(() => {
                TEnum castedEnumeration = (TEnum)value;
            });
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void EqualOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left == right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void EqualOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left == right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void EqualOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left == right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void NotEqualOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left != right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void NotEqualOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left != right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(EqualTestSource))]
        public void NotEqualOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left != right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left > right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left > right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left > right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left < right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left < right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left < right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOrEqualOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left >= right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOrEqualOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left >= right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void GreaterOrEqualOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left >= right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOrEqualOperator_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left <= right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOrEqualOperator_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum left, TValue right, bool ignore2, bool result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left <= right;

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareOperatorTestSource))]
        public void LessOrEqualOperator_ValueAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum ignore, TEnum right, TValue left, bool result, bool ignore2)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            bool actual = left <= right;

            Assert.That(actual, Is.EqualTo(!result));
        }

        [Test]
        public void GetAll_IntEnumeration_ReturnsAllEnumerations() {
            IEnumerable<BasicIntEnumeration> actual = BasicIntEnumeration.GetAll();

            Assert.That(actual, Is.EqualTo(IntEnumerations));
        }

        [Test]
        public void GetAll_StringEnumeration_ReturnsAllEnumerations() {
            IEnumerable<BasicStringEnumeration> actual = BasicStringEnumeration.GetAll();

            Assert.That(actual, Is.EqualTo(StringEnumerations));
        }

        [Test]
        public void GetAll_GuidEnumeration_ReturnsAllEnumerations() {
            IEnumerable<BasicGuidEnumeration> actual = BasicGuidEnumeration.GetAll();

            Assert.That(actual, Is.EqualTo(GuidEnumerations));
        }

        [Test]
        public void GetValues_GetAllIntEnumeration_ReturnsAllValues() {
            IEnumerable<int> actual = BasicIntEnumeration.GetValues();

            Assert.That(actual, Is.EqualTo(IntEnumerations.Select(x => x.Value)));
        }

        [Test]
        public void GetNames_GetAllIntEnumeration_ReturnsAllNames() {
            IEnumerable<string> actual = BasicIntEnumeration.GetNames();

            Assert.That(actual, Is.EqualTo(IntEnumerations.Select(x => x.Name)));
        }

        [Test]
        public void Parse_IntEnumeration_ValidValueProvided_ReturnsEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.Parse(BasicIntEnumeration.One.Value);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void Parse_IntEnumeration_InvalidValueProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicIntEnumeration.Parse(9));
        }

        [Test]
        public void ParseOrDefault_IntEnumeration_ValidValueProvided_ReturnsEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseOrDefault(BasicIntEnumeration.One.Value, BasicIntEnumeration.Zero);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void ParseOrDefault_IntEnumeration_InvalidValueProvided_ReturnsDefaultEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseOrDefault(9, BasicIntEnumeration.Two);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.Two));
        }

        [Test]
        public void Parse_StringEnumeration_ValidValueProvided_ReturnsEnumeration() {
            BasicStringEnumeration actual = BasicStringEnumeration.Parse(BasicStringEnumeration.One.Value);

            Assert.That(actual, Is.SameAs(BasicStringEnumeration.One));
        }

        [Test]
        public void Parse_StringEnumeration_InvalidValueProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicStringEnumeration.Parse("9"));
        }

        [Test]
        public void Parse_GuidEnumeration_ValidValueProvided_ReturnsEnumeration() {
            BasicGuidEnumeration actual = BasicGuidEnumeration.Parse(BasicGuidEnumeration.AllOne.Value);

            Assert.That(actual, Is.SameAs(BasicGuidEnumeration.AllOne));
        }

        [Test]
        public void Parse_GuidEnumeration_InvalidValueProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicGuidEnumeration.Parse(allNine));
        }

        [Test]
        public void TryParse_IntEnumeration_ValidValueProvided_ReturnsTrueAndOutEnumeration() {
            bool actual = BasicIntEnumeration.TryParse(BasicIntEnumeration.One.Value, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicIntEnumeration.One));
            }
        }

        [Test]
        public void TryParse_IntEnumeration_InvalidValueProvided_ReturnsFalseAndOutNull() {
            bool actual = BasicIntEnumeration.TryParse(9, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        public void TryParse_StringEnumeration_ValidValueProvided_ReturnsTrueAndOutEnumeration() {
            bool actual = BasicStringEnumeration.TryParse(BasicStringEnumeration.One.Value, out BasicStringEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicStringEnumeration.One));
            }
        }

        [Test]
        public void TryParse_StringEnumeration_InvalidValueProvided_ReturnsFalseAndOutNull() {
            bool actual = BasicStringEnumeration.TryParse("9", out BasicStringEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        public void TryParse_GuidEnumeration_ValidValueProvided_ReturnsTrueAndOutEnumeration() {
            bool actual = BasicGuidEnumeration.TryParse(BasicGuidEnumeration.AllOne.Value, out BasicGuidEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicGuidEnumeration.AllOne));
            }
        }

        [Test]
        public void TryParse_GuidEnumeration_InvalidValueProvided_ReturnsFalseAndOutNull() {
            bool actual = BasicGuidEnumeration.TryParse(allNine, out BasicGuidEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(9, false)]
        public void IsDefined_IntEnumeration_ValueProvided_ReturnsExpectedResult(int value, bool expected) {
            bool actual = BasicIntEnumeration.IsDefined(value);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ParseName_IntEnumeration_ValidNameProvided_ReturnsEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseName(BasicIntEnumeration.One.Name);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void ParseName_IntEnumeration_InvalidNameProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicIntEnumeration.ParseName("Nine"));
        }

        [Test]
        public void ParseName_StringEnumeration_ValidNameProvided_ReturnsEnumeration() {
            BasicStringEnumeration actual = BasicStringEnumeration.ParseName(BasicStringEnumeration.One.Name);

            Assert.That(actual, Is.SameAs(BasicStringEnumeration.One));
        }

        [Test]
        public void ParseName_StringEnumeration_InvalidNameProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicStringEnumeration.ParseName("Nine"));
        }

        [Test]
        public void ParseName_GuidEnumeration_ValidNameProvided_ReturnsEnumeration() {
            BasicGuidEnumeration actual = BasicGuidEnumeration.ParseName(BasicGuidEnumeration.AllOne.Name);

            Assert.That(actual, Is.SameAs(BasicGuidEnumeration.AllOne));
        }

        [Test]
        public void ParseName_GuidEnumeration_InvalidNameProvided_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicGuidEnumeration.ParseName("AllNine"));
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void ParseName_IntEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsEnumeration(string name, bool ignore) {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseName(name, ignore);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void ParseName_IntEnumeration_LowercaseNameWithIgnoreCaseDisabled_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicIntEnumeration.ParseName("one", false));
        }

        [Test]
        public void ParseNameOrDefault_IntEnumeration_ValidNameProvided_ReturnsEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseNameOrDefault("One", BasicIntEnumeration.Zero);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.One));
        }

        [Test]
        public void ParseNameOrDefault_IntEnumeration_InvalidNameProvided_ReturnsDefaultEnumeration() {
            BasicIntEnumeration actual = BasicIntEnumeration.ParseNameOrDefault("Nine", BasicIntEnumeration.Two);

            Assert.That(actual, Is.SameAs(BasicIntEnumeration.Two));
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void ParseName_StringEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsEnumeration(string name, bool ignore) {
            BasicStringEnumeration actual = BasicStringEnumeration.ParseName(name, ignore);

            Assert.That(actual, Is.SameAs(BasicStringEnumeration.One));
        }

        [Test]
        public void ParseName_StringEnumeration_LowercaseNameWithIgnoreCaseDisabled_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicStringEnumeration.ParseName("one", false));
        }

        [Test]
        [TestCase("AllOne", false)]
        [TestCase("AllOne", true)]
        [TestCase("allone", true)]
        public void ParseName_GuidEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsEnumeration(string name, bool ignore) {
            BasicGuidEnumeration actual = BasicGuidEnumeration.ParseName(name, ignore);

            Assert.That(actual, Is.SameAs(BasicGuidEnumeration.AllOne));
        }

        [Test]
        public void ParseName_GuidEnumeration_LowercaseNameWithIgnoreCaseDisabled_ThrowsEnumerationNotFoundException() {
            // Act & Assert
            Assert.Throws<EnumerationNotFoundException>(() => BasicGuidEnumeration.ParseName("allone", false));
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void TryParseName_IntEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsTrueAndOutEnumeration(string name, bool ignore) {
            bool actual = BasicIntEnumeration.TryParseName(name, ignore, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicIntEnumeration.One));
            }
        }

        [Test]
        public void TryParseName_IntEnumeration_LowercaseNameWithIgnoreCaseDisabled_ReturnsFalseAndOutNull() {
            bool actual = BasicIntEnumeration.TryParseName("one", false, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        [TestCase("One", false)]
        [TestCase("One", true)]
        [TestCase("one", true)]
        public void TryParseName_StringEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsTrueAndOutEnumeration(string name, bool ignore) {
            bool actual = BasicStringEnumeration.TryParseName(name, ignore, out BasicStringEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicStringEnumeration.One));
            }
        }

        [Test]
        public void TryParseName_StringEnumeration_LowercaseNameWithIgnoreCaseDisabled_ReturnsFalseAndOutNull() {
            bool actual = BasicStringEnumeration.TryParseName("one", false, out BasicStringEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        [TestCase("AllOne", false)]
        [TestCase("AllOne", true)]
        [TestCase("allone", true)]
        public void TryParseName_GuidEnumeration_NameMatchesWithIgnoreCaseOption_ReturnsTrueAndOutEnumeration(string name, bool ignore) {
            bool actual = BasicGuidEnumeration.TryParseName(name, ignore, out BasicGuidEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(true));
                Assert.That(enumeration, Is.SameAs(BasicGuidEnumeration.AllOne));
            }
        }

        [Test]
        public void TryParseName_GuidEnumeration_LowercaseNameWithIgnoreCaseDisabled_ReturnsFalseAndOutNull() {
            bool actual = BasicGuidEnumeration.TryParseName("allone", false, out BasicGuidEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(false));
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        [TestCase("One", false, true)]
        [TestCase("one", false, false)]
        [TestCase("one", true, true)]
        [TestCase("Nine", true, false)]
        public void IsDefinedName_IntEnumeration_NameProvided_ReturnsExpectedResult(string name, bool ignoreCase, bool expected) {
            bool actual = BasicIntEnumeration.IsDefinedName(name, ignoreCase);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetValueType_Called_ReturnsExpectedValueType() {
            Type intActual = BasicIntEnumeration.GetValueType();
            Type stringActual = BasicStringEnumeration.GetValueType();
            Type guidActual = BasicGuidEnumeration.GetValueType();

            using (Assert.EnterMultipleScope()) {
                Assert.That(intActual, Is.SameAs(typeof(int)));
                Assert.That(stringActual, Is.SameAs(typeof(string)));
                Assert.That(guidActual, Is.SameAs(typeof(Guid)));
            }
        }

        [Test]
        public void Equals_IntEnumerationComparedWithIntEnumeration_ReturnsExpectedResult() {
            bool sameActual = BasicIntEnumeration.One.Equals(BasicIntEnumeration.One);
            bool differentActual = BasicIntEnumeration.One.Equals(BasicIntEnumeration.Two);

            using (Assert.EnterMultipleScope()) {
                Assert.That(sameActual, Is.EqualTo(true));
                Assert.That(differentActual, Is.EqualTo(false));
            }
        }

        [Test]
        public void Equals_IntEnumerationComparedWithOtherEnumeration_ReturnsFalse() {
            bool differentIntActual = BasicIntEnumeration.One.Equals(BasicIntEnumeration2.One);
            bool differentTypeActual = BasicIntEnumeration.One.Equals(BasicStringEnumeration.One);

            using (Assert.EnterMultipleScope()) {
                Assert.That(differentIntActual, Is.EqualTo(false));
                Assert.That(differentTypeActual, Is.EqualTo(false));
            }
        }

        [Test]
        public void Equals_StringEnumerationComparedWithStringEnumeration_ReturnsExpectedResult() {
            bool sameActual = BasicStringEnumeration.One.Equals(BasicStringEnumeration.One);
            bool differentActual = BasicStringEnumeration.One.Equals(BasicStringEnumeration.Two);

            using (Assert.EnterMultipleScope()) {
                Assert.That(sameActual, Is.EqualTo(true));
                Assert.That(differentActual, Is.EqualTo(false));
            }
        }

        [Test]
        public void Equals_StringEnumerationComparedWithOtherEnumeration_ReturnsFalse() {
            bool differentStringActual = BasicStringEnumeration.One.Equals(BasicStringEnumeration2.One);
            bool differentTypeActual = BasicStringEnumeration.One.Equals(BasicIntEnumeration.One);

            using (Assert.EnterMultipleScope()) {
                Assert.That(differentStringActual, Is.EqualTo(false));
                Assert.That(differentTypeActual, Is.EqualTo(false));
            }
        }

        [Test]
        public void Equals_GuidEnumerationComparedWithGuidEnumeration_ReturnsExpectedResult() {
            bool sameActual = BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration.AllOne);
            bool differentActual = BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration.AllTwo);

            using (Assert.EnterMultipleScope()) {
                Assert.That(sameActual, Is.EqualTo(true));
                Assert.That(differentActual, Is.EqualTo(false));
            }
        }

        [Test]
        public void Equals_GuidEnumerationComparedWithOtherEnumeration_ReturnsFalse() {
            bool differentGuidActual = BasicGuidEnumeration.AllOne.Equals(BasicGuidEnumeration2.AllOne);
            bool differentTypeActual = BasicGuidEnumeration.AllOne.Equals(BasicIntEnumeration.One);

            using (Assert.EnterMultipleScope()) {
                Assert.That(differentGuidActual, Is.EqualTo(false));
                Assert.That(differentTypeActual, Is.EqualTo(false));
            }
        }

        [Test]
        [TestCaseSource(nameof(CompareTestSource))]
        public void CompareTo_EnumerationAndEnumerationCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum right, TValue ignore, int result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            int actual = left.CompareTo(right);

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(CompareTestSource))]
        public void CompareTo_EnumerationAndValueCompared_ReturnsExpectedResult<TEnum, TValue>(TEnum left, TEnum ignore, TValue right, int result)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            int actual = left.CompareTo(right);

            Assert.That(actual, Is.EqualTo(result));
        }
    

        [Test]
        public void GetAll_AliasPropertyDeclared_ReturnsEachInstanceOnceInDeclarationOrder() {
            AliasIntEnumeration[] actual = AliasIntEnumeration.GetAll().ToArray();

            Assert.That(actual, Is.EqualTo(new[] { AliasIntEnumeration.Red, AliasIntEnumeration.Green, AliasIntEnumeration.Blue }).AsCollection);
        }

        [Test]
        public void Parse_AliasPropertyDeclared_ReturnsOriginalInstance() {
            AliasIntEnumeration actual = AliasIntEnumeration.Parse(1);

            Assert.That(actual, Is.SameAs(AliasIntEnumeration.Red));
        }

        [Test]
        public void ParseName_AliasPropertyDeclared_ReturnsOriginalInstance() {
            AliasIntEnumeration actual = AliasIntEnumeration.ParseName(nameof(AliasIntEnumeration.Red));

            Assert.That(actual, Is.SameAs(AliasIntEnumeration.Default));
        }

        [Test]
        public void Parse_DuplicateValueDeclared_ThrowsInvalidOperationException() {
            Assert.Throws<InvalidOperationException>(() => DuplicateValueEnumeration.Parse(1));
        }

        [Test]
        public void Parse_UniqueValueAmongDuplicates_ReturnsMatchingInstance() {
            DuplicateValueEnumeration actual = DuplicateValueEnumeration.Parse(2);

            Assert.That(actual, Is.SameAs(DuplicateValueEnumeration.Green));
        }

        [Test]
        public void ParseName_DuplicateNameIgnoringCase_ThrowsInvalidOperationException() {
            Assert.Throws<InvalidOperationException>(() => DuplicateValueEnumeration.ParseName("GREEN", true));
        }

        [Test]
        public void ParseName_DuplicateNameIgnoringCaseWithOrdinalLookup_ReturnsMatchingInstance() {
            DuplicateValueEnumeration actual = DuplicateValueEnumeration.ParseName("green");

            Assert.That(actual, Is.SameAs(DuplicateValueEnumeration.Lime));
        }

        [Test]
        public void GetAll_CalledDuringStaticInitialization_ThrowsInvalidOperationExceptionWithoutCaching() {
            ReentrantIntEnumeration[] actual = ReentrantIntEnumeration.GetAll().ToArray();

            using (Assert.EnterMultipleScope()) {
                Assert.That(ReentrantIntEnumeration.InitializationException, Is.TypeOf<InvalidOperationException>());
                Assert.That(ReentrantIntEnumeration.InitializationException!.Message, Does.Contain(nameof(ReentrantIntEnumeration.Second)));
                Assert.That(actual, Is.EqualTo(new[] { ReentrantIntEnumeration.First, ReentrantIntEnumeration.Second }).AsCollection);
            }
        }

        [Test]
        public void GetAll_NullableAnnotatedPropertyReturnsNull_IgnoresProperty() {
            NullableMemberEnumeration[] actual = NullableMemberEnumeration.GetAll().ToArray();

            Assert.That(actual, Is.EqualTo(new[] { NullableMemberEnumeration.One }).AsCollection);
        }

        [Test]
        public void GetAll_NonNullablePropertyReturnsNull_ThrowsInvalidOperationException() {
            Assert.Throws<InvalidOperationException>(() => NullMemberEnumeration.GetAll().ToList());
        }

        [Test]
        public void Parse_CalledConcurrentlyBeforeInitialization_ReturnsSameInstances() {
            const int ThreadCount = 8;
            using Barrier barrier = new(ThreadCount);
            ConcurrentInitializationEnumeration[][] results = new ConcurrentInitializationEnumeration[ThreadCount][];
            Thread[] threads = Enumerable.Range(0, ThreadCount)
                .Select(index => new Thread(() => {
                    barrier.SignalAndWait();
                    results[index] = ConcurrentInitializationEnumeration.GetValues()
                        .Select(ConcurrentInitializationEnumeration.Parse)
                        .ToArray();
                }))
                .ToArray();

            foreach (Thread thread in threads) {
                thread.Start();
            }

            foreach (Thread thread in threads) {
                thread.Join();
            }

            ConcurrentInitializationEnumeration[] expected = [
                ConcurrentInitializationEnumeration.One,
                ConcurrentInitializationEnumeration.Two,
                ConcurrentInitializationEnumeration.Three
            ];
            Assert.That(results, Has.All.EqualTo(expected).AsCollection);
        }

        [Test]
        [TestCaseSource(nameof(CastTestSource))]
        public void GetHashCode_EnumerationEqualsValue_ReturnsValueHashCode<TEnum, TValue>(TEnum enumeration, TValue value)
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            using (Assert.EnterMultipleScope()) {
                Assert.That(enumeration.Equals((object)value), Is.True);
                Assert.That(enumeration.GetHashCode(), Is.EqualTo(value.GetHashCode()));
            }
        }

        [Test]
        public void GetHashCode_ValuesAsHashSetKeys_FindsEnumeration() {
            HashSet<object> set = [BasicIntEnumeration.One];

            bool actual = set.Contains(BasicIntEnumeration.One.Value);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void GetAll_CalledTwice_ReturnsSameReadOnlyCollection() {
            IEnumerable<BasicIntEnumeration> first = BasicIntEnumeration.GetAll();

            IEnumerable<BasicIntEnumeration> second = BasicIntEnumeration.GetAll();

            using (Assert.EnterMultipleScope()) {
                Assert.That(second, Is.SameAs(first));
                Assert.That(first, Is.InstanceOf<IReadOnlyList<BasicIntEnumeration>>());
                Assert.That(((ICollection<BasicIntEnumeration>)first).IsReadOnly, Is.True);
            }
        }

        [Test]
        public void GetAll_AddThroughCollectionInterface_ThrowsNotSupportedException() {
            ICollection<BasicIntEnumeration> collection = (ICollection<BasicIntEnumeration>)BasicIntEnumeration.GetAll();

            Assert.Throws<NotSupportedException>(() => collection.Add(BasicIntEnumeration.One));
        }

        [Test]
        public void TryParse_NaNValueDeclared_ReturnsDeclaredInstance() {
            bool actual = FractionDoubleEnumeration.TryParse(double.NaN, out FractionDoubleEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.True);
                Assert.That(enumeration, Is.SameAs(FractionDoubleEnumeration.NotANumber));
            }
        }

        [Test]
        public void TryParse_NullStringValue_ReturnsFalse() {
            bool actual = BasicStringEnumeration.TryParse(null!, out BasicStringEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.False);
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        public void TryParseName_NullName_ReturnsFalse() {
            bool actual = BasicIntEnumeration.TryParseName(null!, true, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.False);
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        public void ExplicitOperator_DuplicateValueDeclared_ThrowsInvalidOperationException() {
            Assert.Throws<InvalidOperationException>(() => _ = (DuplicateValueEnumeration)1);
        }

        [Test]
        public void ExplicitOperator_UndeclaredValue_ThrowsInvalidCastException() {
            Assert.Throws<InvalidCastException>(() => _ = (DuplicateValueEnumeration)9);
        }

        [Test]
        public void ExplicitOperator_AliasPropertyDeclared_ReturnsOriginalInstance() {
            AliasIntEnumeration actual = (AliasIntEnumeration)1;

            Assert.That(actual, Is.SameAs(AliasIntEnumeration.Red));
        }

        [Test]
        public void GetAll_IgnoredPropertiesDeclared_ExcludesIgnoredProperties() {
            IgnoredMemberEnumeration[] actual = IgnoredMemberEnumeration.GetAll().ToArray();

            Assert.That(actual, Is.EqualTo(new[] { IgnoredMemberEnumeration.One, IgnoredMemberEnumeration.Two }).AsCollection);
        }

        [Test]
        public void Parse_IgnoredPropertyWithDuplicateValue_ReturnsDiscoveredInstance() {
            IgnoredMemberEnumeration actual = IgnoredMemberEnumeration.Parse(1);

            Assert.That(actual, Is.SameAs(IgnoredMemberEnumeration.One));
        }

        [Test]
        public void GetCount_AliasPropertyDeclared_ReturnsDistinctMemberCount() {
            int actual = AliasIntEnumeration.GetCount();

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void GetAllAsReadOnly_Always_ReturnsMembersInDeclarationOrder() {
            IReadOnlyList<BasicIntEnumeration> actual = BasicIntEnumeration.GetAllAsReadOnly();

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(IntEnumerations).AsCollection);
                Assert.That(actual[1], Is.SameAs(BasicIntEnumeration.One));
                Assert.That(BasicIntEnumeration.GetAllAsReadOnly(), Is.SameAs(actual));
            }
        }

#if NET9_0_OR_GREATER
        [Test]
        [TestCase("One", false)]
        [TestCase("one", true)]
        public void TryParseName_SpanNameMatches_ReturnsTrueAndOutEnumeration(string name, bool ignoreCase) {
            ReadOnlySpan<char> span = $"[{name}]".AsSpan(1, name.Length);

            bool actual = BasicIntEnumeration.TryParseName(span, ignoreCase, out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.True);
                Assert.That(enumeration, Is.SameAs(BasicIntEnumeration.One));
            }
        }

        [Test]
        public void TryParseName_SpanNameDiffersInCase_ReturnsFalse() {
            bool actual = BasicIntEnumeration.TryParseName("one".AsSpan(), out BasicIntEnumeration? enumeration);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.False);
                Assert.That(enumeration, Is.Null);
            }
        }

        [Test]
        public void TryParseName_SpanNameMatchesDuplicate_ThrowsInvalidOperationException() {
            Assert.Throws<InvalidOperationException>(() => DuplicateValueEnumeration.TryParseName("GREEN".AsSpan(), true, out _));
        }
#endif
}
}
