using System;

namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>The convertible enumeration base.</summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="EnumerationBase&lt;TEnum, TValue&gt;" />
    /// <seealso cref="IConvertible" />
    public abstract class ConvertibleEnumeration<TEnum, TValue> : EnumerationBase<TEnum, TValue>, IConvertible
        where TEnum : ConvertibleEnumeration<TEnum, TValue>
        where TValue : IComparable, IConvertible {
        /// <summary>Initializes a new instance of the <see cref="ConvertibleEnumeration{TEnum, TValue}" /> class.</summary>
        /// <param name="value">The value.</param>
        protected ConvertibleEnumeration(TValue value) : this(value, value.ToString()) { }

        /// <summary>Initializes a new instance of the <see cref="ConvertibleEnumeration{TEnum, TValue}" /> class.</summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected ConvertibleEnumeration(TValue value, string name) : base(value, name) { }

        TypeCode IConvertible.GetTypeCode() {
            return Value.GetTypeCode();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider) {
            return Value.ToBoolean(provider);
        }

        char IConvertible.ToChar(IFormatProvider provider) {
            return Value.ToChar(provider);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider) {
            return Value.ToSByte(provider);
        }

        byte IConvertible.ToByte(IFormatProvider provider) {
            return Value.ToByte(provider);
        }

        short IConvertible.ToInt16(IFormatProvider provider) {
            return Value.ToInt16(provider);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider) {
            return Value.ToUInt16(provider);
        }

        int IConvertible.ToInt32(IFormatProvider provider) {
            return Value.ToInt32(provider);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider) {
            return Value.ToUInt32(provider);
        }

        long IConvertible.ToInt64(IFormatProvider provider) {
            return Value.ToInt64(provider);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider) {
            return Value.ToUInt64(provider);
        }

        float IConvertible.ToSingle(IFormatProvider provider) {
            return Value.ToSingle(provider);
        }

        double IConvertible.ToDouble(IFormatProvider provider) {
            return Value.ToDouble(provider);
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider) {
            return Value.ToDecimal(provider);
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider) {
            return Value.ToDateTime(provider);
        }

        string IConvertible.ToString(IFormatProvider provider) {
            return Value.ToString(provider);
        }

        object IConvertible.ToType(Type type, IFormatProvider provider) {
            try {
                return type == GetType()
                    ? this
                    : type == typeof(TValue)
                        ? Value.ToType(type, provider)
                        : Convert.ChangeType(Value, type);
            } catch (InvalidCastException ex) {
                throw new InvalidCastException($"Invalid cast from '{GetType().FullName}' to '{type.FullName}'.", ex);
            }
        }
    }
}
