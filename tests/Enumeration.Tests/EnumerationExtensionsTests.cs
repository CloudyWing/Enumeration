using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests {
    internal class EnumerationExtensionsTests {
        private static readonly IEnumerable<object[]> TypeTestSource = [
            [BasicIntEnumeration.One.GetType(), true],
            [BasicStringEnumeration.One.GetType(), true],
            [BasicGuidEnumeration.AllZero.GetType(), true],
            [typeof(int), false],
            [typeof(string), false],
            [typeof(Guid), false]
        ];

        private static readonly IEnumerable<object[]> EnumerationTypeTestSource = [
            [BasicIntEnumeration.One.GetType(), new Type[] { typeof(IEnumeration<BasicIntEnumeration, int>) }],
            [BasicStringEnumeration.One.GetType(), new Type[] { typeof(IEnumeration<BasicStringEnumeration, string>) }],
            [BasicGuidEnumeration.AllZero.GetType(), new Type[] { typeof(IEnumeration<BasicGuidEnumeration, Guid>) }],
            [typeof(int), Enumerable.Empty<Type>()],
            [typeof(string), Enumerable.Empty<Type>()],
            [typeof(Guid), Enumerable.Empty<Type>()]
        ];

        private static readonly IEnumerable<object[]> EnumerationValueTypeTestSource = [
            [BasicIntEnumeration.One.GetType(), new Type[] { typeof(int) }],
            [BasicStringEnumeration.One.GetType(), new Type[] { typeof(string) }],
            [BasicGuidEnumeration.AllZero.GetType(), new Type[] { typeof(Guid) }],
            [typeof(int), Enumerable.Empty<Type>()],
            [typeof(string), Enumerable.Empty<Type>()],
            [typeof(Guid), Enumerable.Empty<Type>()]
        ];

        private static readonly IEnumerable<int> IntValues = [0, 1, 2];
        private static readonly IEnumerable<string> IntNames = ["Zero", "One", "Two"];

        [Test]
        [TestCaseSource(nameof(TypeTestSource))]
        public void IsEnumeration_TypeProvided_ReturnsExpectedResult(Type type, bool expected) {
            bool actual = type.IsEnumeration();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCaseSource(nameof(EnumerationTypeTestSource))]
        public void GetEnumerationTypes_TypeProvided_ReturnsExpectedTypes(Type type, IEnumerable<Type> expected) {
            IEnumerable<Type> actual = type.GetEnumerationTypes();

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCaseSource(nameof(EnumerationValueTypeTestSource))]
        public void GetEnumerationValueTypes_TypeProvided_ReturnsExpectedValueTypes(Type type, IEnumerable<Type> expected) {
            IEnumerable<Type> actual = type.GetEnumerationValueTypes();

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        public void ContainsValue_ValueProvided_ReturnsExpectedResult(int value, bool expected) {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            bool actual = enumerations.ContainsValue(value);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("One", false, true)]
        [TestCase("one", false, false)]
        [TestCase("one", true, true)]
        [TestCase("Nine", true, false)]
        public void ContainsName_NameProvided_ReturnsExpectedResult(string name, bool ignoreCase, bool expected) {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            bool actual = enumerations.ContainsName(name, ignoreCase);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void OfValue_GetAll_ReturnsAllValues() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<int> actual = enumerations.OfValue();

            Assert.That(actual, Is.EqualTo(IntValues));
        }

        [Test]
        public void OfName_GetAll_ReturnsAllNames() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<string> actual = enumerations.OfName();

            Assert.That(actual, Is.EqualTo(IntNames));
        }

        [Test]
        public void ToValueArray_GetAll_ReturnsValuesAsArray() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<int> actual = enumerations.ToValueArray();

            Assert.That(actual, Is.EqualTo(IntValues.ToArray()));
        }

        [Test]
        public void ToNameArray_GetAll_ReturnsNamesAsArray() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<string> actual = enumerations.ToNameArray();

            Assert.That(actual, Is.EqualTo(IntNames.ToArray()));
        }

        [Test]
        public void ToValueList_GetAll_ReturnsValuesAsList() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<int> actual = enumerations.ToValueList();

            Assert.That(actual, Is.EqualTo(IntValues.ToList()));
        }

        [Test]
        public void ToNameList_GetAll_ReturnsNamesAsList() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            IEnumerable<string> actual = enumerations.ToNameList();

            Assert.That(actual, Is.EqualTo(IntNames.ToList()));
        }

        [Test]
        public void ToDictionary_GetAll_ReturnsValueNameDictionary() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();
            Dictionary<int, string> expected = new() {
                [BasicIntEnumeration.Zero.Value] = BasicIntEnumeration.Zero.Name,
                [BasicIntEnumeration.One.Value] = BasicIntEnumeration.One.Name,
                [BasicIntEnumeration.Two.Value] = BasicIntEnumeration.Two.Name,
            };

            IDictionary<int, string> actual = enumerations.ToDictionary();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("One", false, true, 1)]
        [TestCase("one", true, true, 1)]
        [TestCase("Nine", true, false, 0)]
        public void TryGetValue_NameProvided_ReturnsExpectedResult(string name, bool ignoreCase, bool expected, int expectedValue) {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            bool actual = enumerations.TryGetValue(name, ignoreCase, out int value);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(expected));
                Assert.That(value, Is.EqualTo(expected ? expectedValue : default));
            }
        }

        [Test]
        [TestCase(1, true, "One")]
        [TestCase(9, false, null)]
        public void TryGetName_ValueProvided_ReturnsExpectedResult(int value, bool expected, string? expectedName) {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();

            bool actual = enumerations.TryGetName(value, out string? name);

            using (Assert.EnterMultipleScope()) {
                Assert.That(actual, Is.EqualTo(expected));
                Assert.That(name, Is.EqualTo(expectedName));
            }
        }

        [Test]
        public void ToNameValueDictionary_GetAll_ReturnsNameValueDictionary() {
            IEnumerable<BasicIntEnumeration> enumerations = BasicIntEnumeration.GetAll();
            Dictionary<string, int> expected = new() {
                [BasicIntEnumeration.Zero.Name] = BasicIntEnumeration.Zero.Value,
                [BasicIntEnumeration.One.Name] = BasicIntEnumeration.One.Value,
                [BasicIntEnumeration.Two.Name] = BasicIntEnumeration.Two.Value,
            };

            IDictionary<string, int> actual = enumerations.ToNameValueDictionary();


            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
