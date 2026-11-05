using System.Text.Json;

namespace CloudyWing.Enumeration.Json.Tests {
    internal class EnumerationJsonConverterTests {
        [Test]
        [TestCase(EnumerationJsonFormat.Value, "2")]
        [TestCase(EnumerationJsonFormat.Name, "\"Green\"")]
        public void Serialize_Format_WritesExpectedJson(EnumerationJsonFormat format, string expected) {
            JsonSerializerOptions options = CreateOptions(new EnumerationJsonConverter<Color, int>(format));

            string actual = JsonSerializer.Serialize(Color.Green, options);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(EnumerationJsonFormat.Value, "1")]
        [TestCase(EnumerationJsonFormat.Name, "\"Red\"")]
        public void Deserialize_Format_ReturnsDeclaredInstance(EnumerationJsonFormat format, string json) {
            JsonSerializerOptions options = CreateOptions(new EnumerationJsonConverter<Color, int>(format));

            Color? actual = JsonSerializer.Deserialize<Color>(json, options);

            Assert.That(actual, Is.SameAs(Color.Red));
        }

        [Test]
        [TestCase(EnumerationJsonFormat.Value, "9")]
        [TestCase(EnumerationJsonFormat.Value, "\"Red\"")]
        [TestCase(EnumerationJsonFormat.Name, "\"Blue\"")]
        [TestCase(EnumerationJsonFormat.Name, "1")]
        public void Deserialize_UndeclaredJson_ThrowsJsonException(EnumerationJsonFormat format, string json) {
            JsonSerializerOptions options = CreateOptions(new EnumerationJsonConverter<Color, int>(format));

            Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<Color>(json, options));
        }

        [Test]
        public void Deserialize_NullToken_ReturnsNull() {
            JsonSerializerOptions options = CreateOptions(new EnumerationJsonConverter<Color, int>());

            Palette? actual = JsonSerializer.Deserialize<Palette>("{\"Primary\":null}", options);

            Assert.That(actual!.Primary, Is.Null);
        }

        [Test]
        [TestCase(EnumerationJsonFormat.Value, "{\"1\":\"warm\"}")]
        [TestCase(EnumerationJsonFormat.Name, "{\"Red\":\"warm\"}")]
        public void Serialize_DictionaryKey_RoundTrips(EnumerationJsonFormat format, string expected) {
            JsonSerializerOptions options = CreateOptions(new EnumerationJsonConverter<Color, int>(format));
            Dictionary<Color, string> source = new() { [Color.Red] = "warm" };

            string json = JsonSerializer.Serialize(source, options);
            Dictionary<Color, string>? actual = JsonSerializer.Deserialize<Dictionary<Color, string>>(json, options);

            using (Assert.EnterMultipleScope()) {
                Assert.That(json, Is.EqualTo(expected));
                Assert.That(actual!.Keys.Single(), Is.SameAs(Color.Red));
            }
        }

        [Test]
        public void Constructor_UndefinedFormat_ThrowsArgumentOutOfRangeException() {
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = new EnumerationJsonConverter<Color, int>((EnumerationJsonFormat)9));
        }

        private static JsonSerializerOptions CreateOptions(System.Text.Json.Serialization.JsonConverter converter) {
            JsonSerializerOptions options = new();
            options.Converters.Add(converter);
            return options;
        }
    }
}
