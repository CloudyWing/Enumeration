using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Json {
    /// <summary>
    /// Creates <see cref="EnumerationJsonConverter{TEnum, TValue}" /> instances for every type derived from
    /// <see cref="EnumerationBase{TEnum, TValue}" />.
    /// </summary>
    /// <remarks>
    /// The factory closes the generic converter type at run time. For trimmed or Native AOT applications, register
    /// <see cref="EnumerationJsonConverter{TEnum, TValue}" /> for each enumeration type instead.
    /// </remarks>
    /// <example>
    /// <code language="csharp">
    /// JsonSerializerOptions options = new() {
    ///     Converters = { new EnumerationJsonConverterFactory(EnumerationJsonFormat.Name) }
    /// };
    /// </code>
    /// </example>
    public class EnumerationJsonConverterFactory : JsonConverterFactory {
        private const string DynamicCodeMessage = "Creating converters for arbitrary enumeration types requires dynamic code. "
            + "Use EnumerationJsonConverter<TEnum, TValue> for Native AOT applications.";
        private const string UnreferencedCodeMessage = "The public properties of enumeration types discovered at run time might be removed by trimming. "
            + "Use EnumerationJsonConverter<TEnum, TValue> for trimmed applications.";

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationJsonConverterFactory" /> class that uses the value format.
        /// </summary>
#if NET7_0_OR_GREATER
        [RequiresDynamicCode(DynamicCodeMessage)]
        [RequiresUnreferencedCode(UnreferencedCodeMessage)]
#endif
        public EnumerationJsonConverterFactory() : this(EnumerationJsonFormat.Value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationJsonConverterFactory" /> class.
        /// </summary>
        /// <param name="format">The JSON representation of the created converters.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="format" /> is not a defined <see cref="EnumerationJsonFormat" /> value.</exception>
#if NET7_0_OR_GREATER
        [RequiresDynamicCode(DynamicCodeMessage)]
        [RequiresUnreferencedCode(UnreferencedCodeMessage)]
#endif
        public EnumerationJsonConverterFactory(EnumerationJsonFormat format) {
            if (format != EnumerationJsonFormat.Value && format != EnumerationJsonFormat.Name) {
                throw new ArgumentOutOfRangeException(nameof(format), format, "The format is not supported.");
            }

            Format = format;
        }

        /// <summary>
        /// Gets the JSON representation of the created converters.
        /// </summary>
        /// <value>The format used by the created converters.</value>
        public EnumerationJsonFormat Format { get; }

        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert) {
            return FindValueType(typeToConvert) is not null;
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException"><paramref name="typeToConvert" /> is not an enumeration type.</exception>
#if NET7_0_OR_GREATER
        [UnconditionalSuppressMessage("AOT", "IL3050", Justification = "The constructors are annotated with RequiresDynamicCode.")]
        [UnconditionalSuppressMessage("Trimming", "IL2071", Justification = "The constructors are annotated with RequiresUnreferencedCode.")]
#endif
        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) {
            Type valueType = FindValueType(typeToConvert)
                ?? throw new ArgumentException($"'{typeToConvert}' is not an enumeration type.", nameof(typeToConvert));
            Type converterType = typeof(EnumerationJsonConverter<,>).MakeGenericType(typeToConvert, valueType);

            return (JsonConverter)Activator.CreateInstance(converterType, Format)!;
        }

        private static Type? FindValueType(Type? type) {
            if (type is null || type.IsAbstract) {
                return null;
            }

            for (Type? current = type.BaseType; current is not null; current = current.BaseType) {
                if (current.IsGenericType
                    && current.GetGenericTypeDefinition() == typeof(EnumerationBase<,>)
                    && current.GenericTypeArguments[0] == type
                ) {
                    return current.GenericTypeArguments[1];
                }
            }

            return null;
        }
    }
}
