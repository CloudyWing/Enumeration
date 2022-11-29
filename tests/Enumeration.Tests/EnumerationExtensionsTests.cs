using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests {
    internal class EnumerationExtensionsTests {
        private static readonly IEnumerable<object[]> typeTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One.GetType(), true },
            new object[] { BasicStringEnumeration.One.GetType(), true },
            new object[] { BasicGuidEnumeration.AllZero.GetType(), true },
            new object[] { typeof(int), false },
            new object[] { typeof(string), false },
            new object[] { typeof(Guid), false }
        };

        private static readonly IEnumerable<object[]> enumerationTypeTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One.GetType(), new Type[] { typeof(IEnumeration<BasicIntEnumeration, int>) } },
            new object[] { BasicStringEnumeration.One.GetType(), new Type[] { typeof(IEnumeration<BasicStringEnumeration, string>) } },
            new object[] { BasicGuidEnumeration.AllZero.GetType(), new Type[] { typeof(IEnumeration<BasicGuidEnumeration, Guid>) } },
            new object[] { typeof(int), Enumerable.Empty<Type>() },
            new object[] { typeof(string), Enumerable.Empty<Type>() },
            new object[] { typeof(Guid), Enumerable.Empty<Type>() }
        };

        private static readonly IEnumerable<object[]> enumerationValueTypeTestSource = new object[][] {
            new object[] { BasicIntEnumeration.One.GetType(), new Type[] { typeof(int) } },
            new object[] { BasicStringEnumeration.One.GetType(), new Type[] { typeof(string) } },
            new object[] { BasicGuidEnumeration.AllZero.GetType(), new Type[] { typeof(Guid) } },
            new object[] { typeof(int), Enumerable.Empty<Type>() },
            new object[] { typeof(string), Enumerable.Empty<Type>() },
            new object[] { typeof(Guid), Enumerable.Empty<Type>() }
        };

        private static readonly IEnumerable<int> intValues = new int[] { 0, 1, 2 };

        private static readonly IEnumerable<string> intNames = new string[] { "Zero", "One", "Two" };

        [Test]
        [TestCaseSource(nameof(typeTestSource))]
        public void IsEnumeration(Type type, bool result) {
            type.IsEnumeration().Should().Be(result);
        }

        [Test]
        [TestCaseSource(nameof(enumerationTypeTestSource))]
        public void GetEnumerationTypes(Type type, IEnumerable<Type> result) {
            type.GetEnumerationTypes().Should().BeEquivalentTo(result);
        }

        [Test]
        [TestCaseSource(nameof(enumerationValueTypeTestSource))]
        public void GetEnumerationValueTypes(Type type, IEnumerable<Type> result) {
            type.GetEnumerationValueTypes().Should().BeEquivalentTo(result);
        }

        [Test]
        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        public void ContainsValue(int value, bool result) {
            BasicIntEnumeration.GetAll().ContainsValue(value).Should().Be(result);
        }

        [Test]
        public void OfValue() {
            BasicIntEnumeration.GetAll().OfValue().Should().Equal(intValues);
        }

        [Test]
        public void OfName() {
            BasicIntEnumeration.GetAll().OfName().Should().Equal(intNames);
        }

        [Test]
        public void ToValueArray() {
            BasicIntEnumeration.GetAll().ToValueArray().Should().Equal(intValues.ToArray());
        }

        [Test]
        public void ToNameArray() {
            BasicIntEnumeration.GetAll().ToNameArray().Should().Equal(intNames.ToArray());
        }

        [Test]
        public void ToValueList() {
            BasicIntEnumeration.GetAll().ToValueList().Should().Equal(intValues.ToList());
        }

        [Test]
        public void ToNameList() {
            BasicIntEnumeration.GetAll().ToNameList().Should().Equal(intNames.ToList());
        }

        [Test]
        public void ToDictionary() {
            Dictionary<int, string> result = new() {
                [BasicIntEnumeration.Zero.Value] = BasicIntEnumeration.Zero.Name,
                [BasicIntEnumeration.One.Value] = BasicIntEnumeration.One.Name,
                [BasicIntEnumeration.Two.Value] = BasicIntEnumeration.Two.Name,
            };
            BasicIntEnumeration.GetAll().ToDictionary().Should().Equal(result);
        }
    }
}
