using System;
using System.Diagnostics.CodeAnalysis;

namespace CloudyWing.Enumeration.Abstractions {
    public abstract partial class EnumerationBase<TEnum, TValue>
#if NET7_0_OR_GREATER
        : IParsable<TEnum>, ISpanParsable<TEnum>
#endif
    {
#if NET7_0_OR_GREATER
        /// <summary>
        /// Parses text that contains the name or the value of a declared enumeration.
        /// </summary>
        /// <param name="s">The text to parse.</param>
        /// <param name="provider">The format provider used to parse the value; <see langword="null" /> uses the current culture.</param>
        /// <returns>The matching enumeration instance.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="s" /> is <see langword="null" />.</exception>
        /// <exception cref="FormatException">No declared enumeration matches <paramref name="s" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="s" />.</exception>
        /// <remarks>
        /// The text is first matched against <see cref="Name" /> with ordinal comparison, and then converted to
        /// <typeparamref name="TValue" /> and matched against <see cref="Value" />.
        /// </remarks>
        static TEnum IParsable<TEnum>.Parse(string s, IFormatProvider? provider) {
            ArgumentNullException.ThrowIfNull(s);

            return TryParseText(s, provider, out TEnum? enumeration)
                ? enumeration
                : throw CreateFormatException(s);
        }

        /// <summary>
        /// Tries to parse text that contains the name or the value of a declared enumeration.
        /// </summary>
        /// <param name="s">The text to parse.</param>
        /// <param name="provider">The format provider used to parse the value; <see langword="null" /> uses the current culture.</param>
        /// <param name="result">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="s" />.</exception>
        static bool IParsable<TEnum>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out TEnum result) {
            return TryParseText(s, provider, out result);
        }

        /// <summary>
        /// Parses characters that contain the name or the value of a declared enumeration.
        /// </summary>
        /// <param name="s">The characters to parse.</param>
        /// <param name="provider">The format provider used to parse the value; <see langword="null" /> uses the current culture.</param>
        /// <returns>The matching enumeration instance.</returns>
        /// <exception cref="FormatException">No declared enumeration matches <paramref name="s" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="s" />.</exception>
        static TEnum ISpanParsable<TEnum>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) {
            return TryParseText(s, provider, out TEnum? enumeration)
                ? enumeration
                : throw CreateFormatException(s.ToString());
        }

        /// <summary>
        /// Tries to parse characters that contain the name or the value of a declared enumeration.
        /// </summary>
        /// <param name="s">The characters to parse.</param>
        /// <param name="provider">The format provider used to parse the value; <see langword="null" /> uses the current culture.</param>
        /// <param name="result">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="s" />.</exception>
        static bool ISpanParsable<TEnum>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out TEnum result) {
            return TryParseText(s, provider, out result);
        }

        private static bool TryParseText(ReadOnlySpan<char> text, IFormatProvider? provider, [MaybeNullWhen(false)] out TEnum enumeration) {
#if NET9_0_OR_GREATER
            // 名稱以字典替代查找比對，只有比對 Value 時才需要建立字串
            return TryParseName(text, out enumeration)
                || TryParseValueText(text.ToString(), provider, out enumeration);
#else
            return TryParseText(text.ToString(), provider, out enumeration);
#endif
        }

        private static FormatException CreateFormatException(string text) {
            return new FormatException($"'{text}' is not the name or the value of a declared enumeration of '{typeof(TEnum).FullName}'.");
        }

#endif
        /// <summary>
        /// 嘗試以名稱或 Value 文字取得已宣告的成員，供 <c>IParsable</c> 與 TypeConverter 共用。
        /// </summary>
        /// <param name="text">名稱或 Value 的文字。</param>
        /// <param name="provider">轉換 Value 時使用的格式提供者。</param>
        /// <param name="enumeration">符合的成員。</param>
        /// <returns>若找到符合的成員則為 <see langword="true" />；否則為 <see langword="false" />。</returns>
        internal static bool TryParseText(string? text, IFormatProvider? provider, [MaybeNullWhen(false)] out TEnum enumeration) {
            if (text is null) {
                enumeration = null;
                return false;
            }

            return TryParseName(text, out enumeration)
                || TryParseValueText(text, provider, out enumeration);
        }

        private static bool TryParseValueText(string text, IFormatProvider? provider, [MaybeNullWhen(false)] out TEnum enumeration) {
            if (EnumerationValueParseUtils.TryParse(text, provider, out TValue value, out bool isSupported)) {
                return TryParse(value, out enumeration);
            }

            if (isSupported) {
                enumeration = null;
                return false;
            }

            // 無法由文字轉換的 Value 型別，改比對成員 Value 的格式化結果
            foreach (TEnum member in GetLookup().Members) {
                string? formatted = member.Value is IFormattable formattable
                    ? formattable.ToString(null, provider)
                    : member.Value?.ToString();

                if (string.Equals(formatted, text, StringComparison.Ordinal)) {
                    enumeration = member;
                    return true;
                }
            }

            enumeration = null;
            return false;
        }
    }
}
