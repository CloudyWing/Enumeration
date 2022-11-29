namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>The sbyte enumeration base.</summary>
    /// <typeparam name="T">The sbyte enumeration.</typeparam>
    public abstract class SByteEnumeration<T> : ConvertibleEnumeration<T, sbyte>
        where T : SByteEnumeration<T> {
        /// <summary>Initializes a new instance of the <see cref="SByteEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        protected SByteEnumeration(sbyte value) : base(value) { }

        /// <summary>Initializes a new instance of the <see cref="SByteEnumeration{T}" /> class.</summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected SByteEnumeration(sbyte value, string name) : base(value, name) { }

        /// <inheritdoc />
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="short" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator short(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="int" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator int(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="long" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator long(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="float" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator float(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="double" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator double(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an implicit conversion from <see cref="SByteEnumeration{T}" /> to <see cref="decimal" />.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator decimal(SByteEnumeration<T> enumeration) {
            return enumeration.Value;
        }

        #region == != > < >= <=
        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, char right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(char left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, byte right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(byte left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, short right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(short left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, ushort right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(ushort left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, int right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(int left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, uint right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(uint left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, long right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(long left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, float right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(float left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, double right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(double left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SByteEnumeration<T> left, decimal right) {
            return left.Value == right;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(decimal left, SByteEnumeration<T> right) {
            return left == right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, char right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(char left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, byte right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(byte left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, short right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(short left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, ushort right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(ushort left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, int right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(int left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, uint right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(uint left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, long right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(long left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, float right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(float left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, double right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(double left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SByteEnumeration<T> left, decimal right) {
            return left.Value != right;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(decimal left, SByteEnumeration<T> right) {
            return left != right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, char right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(char left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, byte right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(byte left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, short right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(short left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, ushort right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(ushort left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, int right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(int left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, uint right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(uint left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, long right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(long left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, float right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(float left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, double right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(double left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(SByteEnumeration<T> left, decimal right) {
            return left.Value > right;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(decimal left, SByteEnumeration<T> right) {
            return left > right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, char right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(char left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, byte right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(byte left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, short right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(short left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, ushort right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(ushort left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, int right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(int left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, uint right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(uint left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, long right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(long left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, float right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(float left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, double right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(double left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(SByteEnumeration<T> left, decimal right) {
            return left.Value < right;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(decimal left, SByteEnumeration<T> right) {
            return left < right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, char right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(char left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, byte right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(byte left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, short right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(short left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, ushort right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(ushort left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, int right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(int left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, uint right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(uint left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, long right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(long left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, float right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(float left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, double right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(double left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(SByteEnumeration<T> left, decimal right) {
            return left.Value >= right;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(decimal left, SByteEnumeration<T> right) {
            return left >= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, char right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(char left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, byte right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(byte left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, short right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(short left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, ushort right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(ushort left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, int right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(int left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, uint right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(uint left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, long right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(long left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, float right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(float left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, double right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(double left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(SByteEnumeration<T> left, decimal right) {
            return left.Value <= right;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(decimal left, SByteEnumeration<T> right) {
            return left <= right.Value;
        }
        #endregion
    }
}
