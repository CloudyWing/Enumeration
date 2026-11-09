using System;
using System.Globalization;

namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>
    /// 將文字轉換為列舉 Value 型別的共用工具。
    /// </summary>
    internal static class EnumerationValueParseUtils {
        /// <summary>
        /// 嘗試將文字轉換為指定的 Value 型別。
        /// </summary>
        /// <typeparam name="TValue">Value 的型別。</typeparam>
        /// <param name="text">要轉換的文字。</param>
        /// <param name="provider">格式提供者；為 <see langword="null" /> 時使用目前文化特性。</param>
        /// <param name="value">轉換後的值。</param>
        /// <param name="isSupported">若型別支援文字轉換則為 <see langword="true" />；否則為 <see langword="false" />。</param>
        /// <returns>若轉換成功則為 <see langword="true" />；否則為 <see langword="false" />。</returns>
        public static bool TryParse<TValue>(string text, IFormatProvider? provider, out TValue value, out bool isSupported) {
            isSupported = true;

            if (TryParseCore(typeof(TValue), text, provider, out object? result, ref isSupported) && result is TValue typed) {
                value = typed;
                return true;
            }

            value = default!;
            return false;
        }

        private static bool TryParseCore(Type type, string text, IFormatProvider? provider, out object? result, ref bool isSupported) {
            result = null;

            if (type == typeof(string)) {
                result = text;
                return true;
            }

            if (type == typeof(Guid)) {
                bool isGuid = Guid.TryParse(text, out Guid guid);
                result = guid;
                return isGuid;
            }

            if (type.IsEnum) {
                return TryParseEnum(type, text, out result);
            }

            switch (Type.GetTypeCode(type)) {
                case TypeCode.Boolean:
                    return TryAssign(bool.TryParse(text, out bool booleanValue), booleanValue, out result);
                case TypeCode.Char:
                    return TryAssign(text.Length == 1, text.Length == 1 ? text[0] : default, out result);
                case TypeCode.SByte:
                    return TryAssign(sbyte.TryParse(text, NumberStyles.Integer, provider, out sbyte sbyteValue), sbyteValue, out result);
                case TypeCode.Byte:
                    return TryAssign(byte.TryParse(text, NumberStyles.Integer, provider, out byte byteValue), byteValue, out result);
                case TypeCode.Int16:
                    return TryAssign(short.TryParse(text, NumberStyles.Integer, provider, out short shortValue), shortValue, out result);
                case TypeCode.UInt16:
                    return TryAssign(ushort.TryParse(text, NumberStyles.Integer, provider, out ushort ushortValue), ushortValue, out result);
                case TypeCode.Int32:
                    return TryAssign(int.TryParse(text, NumberStyles.Integer, provider, out int intValue), intValue, out result);
                case TypeCode.UInt32:
                    return TryAssign(uint.TryParse(text, NumberStyles.Integer, provider, out uint uintValue), uintValue, out result);
                case TypeCode.Int64:
                    return TryAssign(long.TryParse(text, NumberStyles.Integer, provider, out long longValue), longValue, out result);
                case TypeCode.UInt64:
                    return TryAssign(ulong.TryParse(text, NumberStyles.Integer, provider, out ulong ulongValue), ulongValue, out result);
                case TypeCode.Single:
                    return TryAssign(
                        float.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, provider, out float floatValue),
                        floatValue,
                        out result
                    );
                case TypeCode.Double:
                    return TryAssign(
                        double.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, provider, out double doubleValue),
                        doubleValue,
                        out result
                    );
                case TypeCode.Decimal:
                    return TryAssign(decimal.TryParse(text, NumberStyles.Number, provider, out decimal decimalValue), decimalValue, out result);
                case TypeCode.DateTime:
                    return TryAssign(
                        DateTime.TryParse(text, provider, DateTimeStyles.None, out DateTime dateTimeValue),
                        dateTimeValue,
                        out result
                    );
                default:
                    isSupported = false;
                    return false;
            }
        }

        private static bool TryParseEnum(Type type, string text, out object? result) {
            try {
                result = Enum.Parse(type, text, false);
                return true;
            } catch (ArgumentException) {
                result = null;
                return false;
            } catch (OverflowException) {
                result = null;
                return false;
            }
        }

        private static bool TryAssign<T>(bool isParsed, T parsed, out object? result) {
            result = isParsed ? parsed : null;
            return isParsed;
        }
    }
}
