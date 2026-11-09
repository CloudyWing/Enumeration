using System.Text.Json;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Json.Tests {
    internal class EnumerationJsonConverterFactoryTests {
        [Test]
        [TestCase(typeof(Color), true)]
        [TestCase(typeof(Size), true)]
        [TestCase(typeof(EnumerationBase<Color, int>), false)]
        [TestCase(typeof(int), false)]
        [TestCase(typeof(string), false)]
        public void CanConvert_Type_ReturnsExpectedResult(Type type, bool expected) {
            EnumerationJsonConverterFactory factory = new();

            bool actual = factory.CanConvert(type);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(EnumerationJsonFormat.Value, "{\"Primary\":2,\"Size\":\"L\"}")]
        [TestCase(EnumerationJsonFormat.Name, "{\"Primary\":\"Green\",\"Size\":\"Large\"}")]
        public void Serialize_ObjectWithEnumerations_RoundTripsDeclaredInstances(EnumerationJsonFormat format, string expected) {
            JsonSerializerOptions options = new();
            options.Converters.Add(new EnumerationJsonConverterFactory(format));
            Palette source = new() { Primary = Color.Green, Size = Size.Large };

            string json = JsonSerializer.Serialize(source, options);
            Palette? actual = JsonSerializer.Deserialize<Palette>(json, options);

            using (Assert.EnterMultipleScope()) {
                Assert.That(json, Is.EqualTo(expected));
                Assert.That(actual!.Primary, Is.SameAs(Color.Green));
                Assert.That(actual.Size, Is.SameAs(Size.Large));
            }
        }

        [Test]
        public void CreateConverter_NonEnumerationType_ThrowsArgumentException() {
            EnumerationJsonConverterFactory factory = new();

            Assert.Throws<ArgumentException>(() => factory.CreateConverter(typeof(int), new JsonSerializerOptions()));
        }
    }
}
