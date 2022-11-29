namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>The long enumeration base.</summary>
    /// <typeparam name="T">The long enumeration.</typeparam>
    public abstract class LongEnumeration<T> : ConvertibleEnumeration<T, long>
        where T : LongEnumeration<T> {
        /// <summary>Initializes a new instance of the <see cref="LongEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        protected LongEnumeration(long value) : base(value) { }

        /// <summary>Initializes a new instance of the <see cref="LongEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected LongEnumeration(long value, string name) : base(value, name) { }

        /// <inheritdoc />
        public override bool Equals(object obj) {
            switch (obj) {
                case char c:
                    return Value.Equals(c);
                case byte b:
                    return Value.Equals(b);
                case sbyte sb:
                    return Value.Equals(sb);
                case short s:
                    return Value.Equals(s);
                case ushort us:
                    return Value.Equals(us);
                case int i:
                    return Value.Equals(i);
                case uint ui:
                    return Value.Equals(ui);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <summary>Performs an implicit conversion from <see cref="LongEnumeration{T}" /> to <see cref="float" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator float(LongEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="LongEnumeration{T}" /> to <see cref="double" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator double(LongEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="LongEnumeration{T}" /> to <see cref="decimal" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator decimal(LongEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        #region == != > < >= <=
        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(LongEnumeration<T> left, decimal right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(decimal left, LongEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(LongEnumeration<T> left, decimal right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(decimal left, LongEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(decimal left, LongEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(decimal left, LongEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(decimal left, LongEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(decimal left, LongEnumeration<T> right) {
            return left <= right.Value;
        }
        #endregion
    }
}
