namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>The int enumeration base.</summary>
    /// <typeparam name="T">The int enumeration.</typeparam>
    public abstract class IntEnumeration<T> : ConvertibleEnumeration<T, int>
        where T : IntEnumeration<T> {
        /// <summary>Initializes a new instance of the <see cref="IntEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        protected IntEnumeration(int value) : base(value) { }

        /// <summary>Initializes a new instance of the <see cref="IntEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected IntEnumeration(int value, string name) : base(value, name) { }

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
            }

            return base.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <summary>Performs an implicit conversion from <see cref="IntEnumeration{T}" /> to <see cref="long" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator long(IntEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="IntEnumeration{T}" /> to <see cref="float" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator float(IntEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="IntEnumeration{T}" /> to <see cref="double" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator double(IntEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="IntEnumeration{T}" /> to <see cref="decimal" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator decimal(IntEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        #region == != > < >= <=
        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, char right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(char left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, byte right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(byte left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, sbyte right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(sbyte left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, short right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(short left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, ushort right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(ushort left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, uint right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(uint left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, long right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(long left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, float right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(float left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, double right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(double left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IntEnumeration<T> left, decimal right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(decimal left, IntEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, char right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(char left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, byte right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(byte left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, sbyte right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(sbyte left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, short right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(short left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, ushort right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(ushort left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, uint right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(uint left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, long right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(long left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, float right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(float left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, double right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(double left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IntEnumeration<T> left, decimal right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(decimal left, IntEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, char right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(char left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, byte right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(byte left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, sbyte right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(sbyte left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, short right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(short left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, ushort right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(ushort left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, uint right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(uint left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, long right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(long left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, float right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(float left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, double right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(double left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(IntEnumeration<T> left, decimal right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(decimal left, IntEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, char right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(char left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, byte right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(byte left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, sbyte right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(sbyte left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, short right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(short left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, ushort right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(ushort left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, uint right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(uint left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, long right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(long left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, float right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(float left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, double right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(double left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(IntEnumeration<T> left, decimal right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(decimal left, IntEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, char right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(char left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, byte right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(byte left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, sbyte right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(sbyte left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, short right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(short left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, ushort right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(ushort left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, uint right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(uint left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, long right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(long left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, float right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(float left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, double right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(double left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(IntEnumeration<T> left, decimal right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(decimal left, IntEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, char right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(char left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, byte right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(byte left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, sbyte right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(sbyte left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, short right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(short left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, ushort right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(ushort left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, uint right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(uint left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, long right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(long left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, float right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(float left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, double right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(double left, IntEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(IntEnumeration<T> left, decimal right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(decimal left, IntEnumeration<T> right) {
            return left <= right.Value;
        }
        #endregion
    }
}
