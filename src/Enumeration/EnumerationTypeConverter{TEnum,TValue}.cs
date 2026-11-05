using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration {
    /// <summary>
    /// Converts between an enumeration and its name, its value, or the text form of its value.
    /// </summary>
    /// <typeparam name="TEnum">The enumeration type.</typeparam>
    /// <typeparam name="TValue">The underlying value type.</typeparam>
    /// <remarks>
    /// Text is matched against <see cref="EnumerationBase{TEnum, TValue}.Name" /> with ordinal comparison first, and then converted to
    /// <typeparamref name="TValue" /> with the supplied culture and matched against <see cref="EnumerationBase{TEnum, TValue}.Value" />.
    /// Empty or white-space text converts to <see langword="null" />. Conversion to <see cref="string" /> returns the name.
    /// Apply the converter with <see cref="TypeConverterAttribute" />, or register it with
    /// <see cref="EnumerationTypeConverter.Register{TEnum, TValue}" />.
    /// </remarks>
    public class EnumerationTypeConverter<TEnum, TValue> : TypeConverter
        where TEnum : EnumerationBase<TEnum, TValue>
        where TValue : IComparable {
        /// <inheritdoc />
        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) {
            return sourceType == typeof(string)
                || sourceType == typeof(TValue)
                || base.CanConvertFrom(context, sourceType);
        }

        /// <inheritdoc />
        public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) {
            return destinationType == typeof(string)
                || destinationType == typeof(TValue)
                || base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Converts a name, a value, or the text form of a value to the declared enumeration instance.
        /// </summary>
        /// <param name="context">The format context.</param>
        /// <param name="culture">The culture used to convert value text; <see langword="null" /> uses the current culture.</param>
        /// <param name="value">The name, value, or value text to convert.</param>
        /// <returns>The matching enumeration instance, or <see langword="null" /> when <paramref name="value" /> is empty or white-space text.</returns>
        /// <exception cref="FormatException">No declared enumeration matches <paramref name="value" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        /// <exception cref="NotSupportedException"><paramref name="value" /> is neither text nor <typeparamref name="TValue" />.</exception>
        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) {
            if (value is string text) {
                if (string.IsNullOrWhiteSpace(text)) {
                    return null;
                }

                return EnumerationBase<TEnum, TValue>.TryParseText(text, culture ?? CultureInfo.CurrentCulture, out TEnum? enumeration)
                    ? enumeration
                    : throw CreateFormatException(text);
            }

            if (value is TValue typedValue) {
                return EnumerationBase<TEnum, TValue>.TryParse(typedValue, out TEnum? enumeration)
                    ? enumeration
                    : throw CreateFormatException(typedValue);
            }

            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts an enumeration instance to its name or its value.
        /// </summary>
        /// <param name="context">The format context.</param>
        /// <param name="culture">The culture to use.</param>
        /// <param name="value">The enumeration instance to convert.</param>
        /// <param name="destinationType">The type to convert to.</param>
        /// <returns>The name when <paramref name="destinationType" /> is <see cref="string" />; the value when it is <typeparamref name="TValue" />.</returns>
        /// <exception cref="NotSupportedException">The conversion cannot be performed.</exception>
        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
            if (value is TEnum enumeration) {
                if (destinationType == typeof(string)) {
                    return enumeration.Name;
                }

                if (destinationType == typeof(TValue)) {
                    return enumeration.Value;
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <inheritdoc />
        public override bool IsValid(ITypeDescriptorContext? context, object? value) {
            return value switch {
                string text => EnumerationBase<TEnum, TValue>.TryParseText(text, CultureInfo.CurrentCulture, out _),
                TValue typedValue => EnumerationBase<TEnum, TValue>.IsDefined(typedValue),
                TEnum => true,
                _ => false
            };
        }

        /// <inheritdoc />
        public override bool GetStandardValuesSupported(ITypeDescriptorContext? context) {
            return true;
        }

        /// <inheritdoc />
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context) {
            return true;
        }

        /// <inheritdoc />
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext? context) {
            return new StandardValuesCollection(EnumerationBase<TEnum, TValue>.GetAllAsReadOnly().ToArray());
        }

        private static FormatException CreateFormatException(object? value) {
            return new FormatException($"'{value}' is not the name or the value of a declared enumeration of '{typeof(TEnum).FullName}'.");
        }
    }
}
