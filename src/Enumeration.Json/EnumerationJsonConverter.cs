using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Json {
    /// <summary>
    /// Converts an enumeration to and from JSON by its value or by its name.
    /// </summary>
    /// <typeparam name="TEnum">The enumeration type.</typeparam>
    /// <typeparam name="TValue">The underlying value type.</typeparam>
    /// <remarks>
    /// In <see cref="EnumerationJsonFormat.Value" /> format the value is read and written with the JSON metadata of
    /// <typeparamref name="TValue" /> resolved from the serializer options, so the converter also works with source-generated contexts
    /// that include <typeparamref name="TValue" />. Reading JSON that does not match a declared enumeration throws <see cref="JsonException" />.
    /// The converter also supports dictionary keys.
    /// </remarks>
    /// <example>
    /// <code language="csharp">
    /// JsonSerializerOptions options = new() {
    ///     Converters = { new EnumerationJsonConverter&lt;WeekDay, int&gt;(EnumerationJsonFormat.Name) }
    /// };
    /// string json = JsonSerializer.Serialize(WeekDay.Monday, options);
    /// </code>
    /// </example>
    public class EnumerationJsonConverter<TEnum, TValue> : JsonConverter<TEnum>
        where TEnum : EnumerationBase<TEnum, TValue>
        where TValue : IComparable {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationJsonConverter{TEnum, TValue}" /> class that uses the value format.
        /// </summary>
        public EnumerationJsonConverter() : this(EnumerationJsonFormat.Value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationJsonConverter{TEnum, TValue}" /> class.
        /// </summary>
        /// <param name="format">The JSON representation of the enumeration.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="format" /> is not a defined <see cref="EnumerationJsonFormat" /> value.</exception>
        public EnumerationJsonConverter(EnumerationJsonFormat format) {
            if (format != EnumerationJsonFormat.Value && format != EnumerationJsonFormat.Name) {
                throw new ArgumentOutOfRangeException(nameof(format), format, "The format is not supported.");
            }

            Format = format;
        }

        /// <summary>
        /// Gets the JSON representation of the enumeration.
        /// </summary>
        /// <value>The format used to read and write the enumeration.</value>
        public EnumerationJsonFormat Format { get; }

        /// <inheritdoc />
        public override TEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (Format == EnumerationJsonFormat.Name) {
                if (reader.TokenType != JsonTokenType.String) {
                    throw new JsonException($"Expected a JSON string containing the name of '{typeof(TEnum).FullName}', but found {reader.TokenType}.");
                }

                return FindByName(reader.GetString());
            }

            TValue? value = JsonSerializer.Deserialize(ref reader, GetValueTypeInfo(options));
            return FindByValue(value);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options) {
            if (writer is null) {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null) {
                writer.WriteNullValue();
                return;
            }

            if (Format == EnumerationJsonFormat.Name) {
                writer.WriteStringValue(value.Name);
                return;
            }

            JsonSerializer.Serialize(writer, value.Value, GetValueTypeInfo(options));
        }

        /// <inheritdoc />
        public override TEnum ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (Format == EnumerationJsonFormat.Name) {
                return FindByName(reader.GetString());
            }

            TValue value = GetValueConverter(options).ReadAsPropertyName(ref reader, typeof(TValue), options);
            return FindByValue(value);
        }

        /// <inheritdoc />
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options) {
            if (writer is null) {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null) {
                throw new ArgumentNullException(nameof(value));
            }

            if (Format == EnumerationJsonFormat.Name) {
                writer.WritePropertyName(value.Name);
                return;
            }

            GetValueConverter(options).WriteAsPropertyName(writer, value.Value, options);
        }

        private static JsonTypeInfo<TValue> GetValueTypeInfo(JsonSerializerOptions options) {
            if (options is null) {
                throw new ArgumentNullException(nameof(options));
            }

            return (JsonTypeInfo<TValue>)options.GetTypeInfo(typeof(TValue));
        }

        private static JsonConverter<TValue> GetValueConverter(JsonSerializerOptions options) {
            return (JsonConverter<TValue>)GetValueTypeInfo(options).Converter;
        }

        private static TEnum FindByName(string? name) {
            if (name is not null && EnumerationBase<TEnum, TValue>.TryParseName(name, out TEnum? enumeration)) {
                return enumeration;
            }

            throw new JsonException($"'{name}' is not the name of a declared enumeration of '{typeof(TEnum).FullName}'.");
        }

        private static TEnum FindByValue(TValue? value) {
            if (value is not null && EnumerationBase<TEnum, TValue>.TryParse(value, out TEnum? enumeration)) {
                return enumeration;
            }

            throw new JsonException($"'{value}' is not the value of a declared enumeration of '{typeof(TEnum).FullName}'.");
        }
    }
}
