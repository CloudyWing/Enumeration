namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>The ushort enumeration base.</summary>
    /// <typeparam name="T">The ushort enumeration.</typeparam>
    public abstract class UShortEnumeration<T> : ConvertibleEnumeration<T, ushort>
        where T : UShortEnumeration<T> {
        /// <summary>Initializes a new instance of the <see cref="UShortEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        protected UShortEnumeration(ushort value) : base(value) { }

        /// <summary>Initializes a new instance of the <see cref="UShortEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected UShortEnumeration(ushort value, string name) : base(value, name) { }

        /// <inheritdoc />
        public override bool Equals(object obj) {
            switch (obj) {
                case char c:
                    return Value.Equals(c);
                case byte b:
                    return Value.Equals(b);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="int" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator int(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="uint" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator uint(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="long" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator long(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="ulong" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ulong(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="float" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator float(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="double" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator double(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="UShortEnumeration{T}" /> to <see cref="decimal" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator decimal(UShortEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        #region == != > < >= <=
        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, char right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(char left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, byte right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(byte left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, sbyte right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(sbyte left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, short right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(short left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, ushort right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(ushort left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, int right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(int left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, uint right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(uint left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, long right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(long left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, ulong right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(ulong left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, float right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(float left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, double right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(double left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UShortEnumeration<T> left, decimal right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(decimal left, UShortEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, char right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(char left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, byte right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(byte left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, sbyte right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(sbyte left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, short right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(short left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, ushort right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(ushort left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, int right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(int left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, uint right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(uint left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, long right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(long left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, ulong right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(ulong left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, float right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(float left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, double right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(double left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UShortEnumeration<T> left, decimal right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(decimal left, UShortEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, char right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(char left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, byte right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(byte left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, sbyte right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(sbyte left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, short right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(short left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, ushort right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(ushort left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, int right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(int left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, uint right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(uint left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, long right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(long left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, ulong right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(ulong left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, float right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(float left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, double right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(double left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(UShortEnumeration<T> left, decimal right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(decimal left, UShortEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, char right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(char left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, byte right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(byte left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, sbyte right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(sbyte left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, short right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(short left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, ushort right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(ushort left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, int right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(int left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, uint right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(uint left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, long right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(long left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, ulong right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(ulong left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, float right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(float left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, double right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(double left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(UShortEnumeration<T> left, decimal right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(decimal left, UShortEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, char right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(char left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, byte right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(byte left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, sbyte right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(sbyte left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, short right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(short left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, ushort right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(ushort left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, int right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(int left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, uint right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(uint left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, long right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(long left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, ulong right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(ulong left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, float right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(float left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, double right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(double left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(UShortEnumeration<T> left, decimal right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(decimal left, UShortEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, char right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(char left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, byte right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(byte left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, sbyte right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(sbyte left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, short right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(short left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, ushort right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(ushort left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, int right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(int left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, uint right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(uint left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, long right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(long left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, ulong right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(ulong left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, float right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(float left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, double right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(double left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(UShortEnumeration<T> left, decimal right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(decimal left, UShortEnumeration<T> right) {
            return left <= right.Value;
        }
        #endregion
    }
}
