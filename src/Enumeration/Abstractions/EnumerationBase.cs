using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;

namespace CloudyWing.Enumeration.Abstractions {
    /// <summary>
    /// Represents the base type for class-based enumerations.
    /// </summary>
    /// <typeparam name="TEnum">The concrete enumeration type.</typeparam>
    /// <typeparam name="TValue">The underlying value type.</typeparam>
    /// <remarks>
    /// Enumeration instances are discovered from readable public static properties declared directly on <typeparamref name="TEnum" />.
    /// A property that returns an instance already returned by an earlier property, such as an alias like <c>Default => Red</c>,
    /// does not create another member; the instance keeps the position of its first declaring property.
    /// Properties marked with <see cref="EnumerationIgnoreAttribute" /> are not discovered.
    /// <para>
    /// Members are discovered on first use. Accessing them through lookup members such as <see cref="GetAll" />,
    /// <see cref="Parse(TValue)" /> or <see cref="TryParse(TValue, out TEnum)" /> while the static initialization of
    /// <typeparamref name="TEnum" /> is still running throws <see cref="InvalidOperationException" />,
    /// because members declared later are still <see langword="null" />. The failed discovery is not cached.
    /// </para>
    /// <para>
    /// The type is marked <see cref="SerializableAttribute" /> and implements <see cref="IObjectReference" />, so serializers that honor
    /// <see cref="IObjectReference" />, such as <c>BinaryFormatter</c> on .NET Framework and <c>DataContractSerializer</c>,
    /// return the declared instance instead of a copy. Derived types must also be marked <see cref="SerializableAttribute" />.
    /// </para>
    /// <para>
    /// On .NET 7 or later the type explicitly implements <c>IParsable&lt;TEnum&gt;</c> and <c>ISpanParsable&lt;TEnum&gt;</c>.
    /// Parsing matches the text against <see cref="Name" /> first and then against the text form of <see cref="Value" />.
    /// </para>
    /// </remarks>
    /// <seealso cref="IEnumeration&lt;TEnum, TValue&gt;" />
    /// <seealso cref="IEquatable&lt;TEnum&gt;" />
    /// <seealso cref="IComparable&lt;TEnum&gt;" />
    [Serializable]
#pragma warning disable SYSLIB0050 // net10 已移除 BinaryFormatter，但 DataContractSerializer 等序列化器仍會呼叫 IObjectReference
    public abstract partial class EnumerationBase<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] TEnum, TValue> : IEnumeration<TEnum, TValue>, IEquatable<TEnum>, IComparable<TEnum>, IObjectReference
#pragma warning restore SYSLIB0050
        where TEnum : EnumerationBase<TEnum, TValue>
        where TValue : IComparable {
        private const string NullableAttributeName = "System.Runtime.CompilerServices.NullableAttribute";
        private const string NullableContextAttributeName = "System.Runtime.CompilerServices.NullableContextAttribute";
        private const byte NullableAnnotatedFlag = 2;
        private static readonly object SyncRoot = new object();
        private static readonly DeferredMemberList AllMembers = new DeferredMemberList();
        private static EnumerationLookup? lookup;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationBase{TEnum, TValue}" /> class.
        /// </summary>
        /// <param name="value">The underlying enumeration value.</param>
        /// <exception cref="InvalidOperationException"><paramref name="value" /> returns a <see langword="null" /> string representation.</exception>
        protected EnumerationBase(TValue value)
            : this(
                value,
                value.ToString() ?? throw new InvalidOperationException($"{typeof(TValue).FullName} returned a null string representation.")
            ) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationBase{TEnum, TValue}" /> class.
        /// </summary>
        /// <param name="value">The underlying enumeration value.</param>
        /// <param name="name">The display name.</param>
        protected EnumerationBase(TValue value, string name) {
            Value = value;
            Name = name;
        }

        /// <summary>
        /// Gets the underlying value of the enumeration.
        /// </summary>
        /// <value>The value used to identify the enumeration instance.</value>
        public TValue Value { get; }

        /// <summary>
        /// Gets the display name of the enumeration.
        /// </summary>
        /// <value>The display name associated with the enumeration instance.</value>
        public string Name { get; }

        /// <summary>
        /// Gets all declared enumeration instances.
        /// </summary>
        /// <returns>The declared enumeration instances.</returns>
        /// <remarks>
        /// Instances are returned in the same order as their declaring public static properties on <typeparamref name="TEnum" />.
        /// The method returns the same cached read-only collection on every call, and members are discovered when the collection is first read.
        /// </remarks>
        public static IEnumerable<TEnum> GetAll() {
            return AllMembers;
        }

        /// <summary>
        /// Gets all declared enumeration instances as a read-only list.
        /// </summary>
        /// <returns>The cached read-only list of declared enumeration instances, in declaration order.</returns>
        /// <remarks>
        /// Unlike <see cref="GetAll" />, members are discovered when this method is called.
        /// </remarks>
        public static IReadOnlyList<TEnum> GetAllAsReadOnly() {
            return GetLookup().ReadOnlyMembers;
        }

        /// <summary>
        /// Gets the number of declared enumeration instances.
        /// </summary>
        /// <returns>The number of declared enumeration instances.</returns>
        public static int GetCount() {
            return GetLookup().Members.Length;
        }

        /// <summary>
        /// Gets the values of all declared enumeration instances.
        /// </summary>
        /// <returns>The declared enumeration values.</returns>
        public static IEnumerable<TValue> GetValues() {
            foreach (TEnum enumeration in GetLookup().Members) {
                yield return enumeration.Value;
            }
        }

        /// <summary>
        /// Gets the names of all declared enumeration instances.
        /// </summary>
        /// <returns>The declared enumeration names.</returns>
        public static IEnumerable<string> GetNames() {
            foreach (TEnum enumeration in GetLookup().Members) {
                yield return enumeration.Name;
            }
        }

        /// <summary>
        /// Gets the declared enumeration instance that matches the specified value.
        /// </summary>
        /// <param name="value">The value to match.</param>
        /// <returns>The matching enumeration instance.</returns>
        /// <exception cref="EnumerationNotFoundException">No declared enumeration matches <paramref name="value" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        public static TEnum Parse(TValue value) {
            return TryParse(value, out TEnum? enumeration)
                ? enumeration
                : throw new EnumerationNotFoundException();
        }

        /// <summary>
        /// Gets the declared enumeration instance that matches the specified value, or returns a fallback instance.
        /// </summary>
        /// <param name="value">The value to match.</param>
        /// <param name="defaultEnumeration">The enumeration to return when no match is found.</param>
        /// <returns>The parsed enumeration if it exists; otherwise, <paramref name="defaultEnumeration" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="defaultEnumeration" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        public static TEnum ParseOrDefault(TValue value, TEnum defaultEnumeration) {
            if (defaultEnumeration is null) {
                throw new ArgumentNullException(nameof(defaultEnumeration));
            }

            return TryParse(value, out TEnum? enumeration)
                ? enumeration
                : defaultEnumeration;
        }

        /// <summary>
        /// Tries to get the declared enumeration instance that matches the specified value.
        /// </summary>
        /// <param name="value">The value to match.</param>
        /// <param name="enumeration">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        public static bool TryParse(TValue value, [MaybeNullWhen(false)] out TEnum enumeration) {
            return GetLookup().TryGetByValue(value, out enumeration);
        }

        /// <summary>
        /// Determines whether the specified value matches a declared enumeration.
        /// </summary>
        /// <param name="value">The value to match.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        public static bool IsDefined(TValue value) {
            return TryParse(value, out _);
        }

        /// <summary>
        /// Gets the declared enumeration instance that matches the specified name.
        /// </summary>
        /// <param name="name">The name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <returns>The matching enumeration instance.</returns>
        /// <exception cref="EnumerationNotFoundException">No declared enumeration matches <paramref name="name" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static TEnum ParseName(string name, bool ignoreCase = false) {
            return TryParseName(name, ignoreCase, out TEnum? enumeration)
                ? enumeration
                : throw new EnumerationNotFoundException();
        }

        /// <summary>
        /// Gets the declared enumeration instance that matches the specified name, or returns a fallback instance.
        /// </summary>
        /// <param name="name">The name to match.</param>
        /// <param name="defaultEnumeration">The enumeration to return when no match is found.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <returns>The parsed enumeration if it exists; otherwise, <paramref name="defaultEnumeration" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="defaultEnumeration" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static TEnum ParseNameOrDefault(string name, TEnum defaultEnumeration, bool ignoreCase = false) {
            if (defaultEnumeration is null) {
                throw new ArgumentNullException(nameof(defaultEnumeration));
            }

            return TryParseName(name, ignoreCase, out TEnum? enumeration)
                ? enumeration
                : defaultEnumeration;
        }

        /// <summary>
        /// Tries to get the declared enumeration instance that matches the specified name.
        /// </summary>
        /// <param name="name">The name to match.</param>
        /// <param name="enumeration">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static bool TryParseName(string name, [MaybeNullWhen(false)] out TEnum enumeration) {
            return TryParseName(name, false, out enumeration);
        }

        /// <summary>
        /// Tries to get the declared enumeration instance that matches the specified name.
        /// </summary>
        /// <param name="name">The name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <param name="enumeration">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static bool TryParseName(string name, bool ignoreCase, [MaybeNullWhen(false)] out TEnum enumeration) {
            return GetLookup().TryGetByName(name, ignoreCase, out enumeration);
        }

#if NET9_0_OR_GREATER
        /// <summary>
        /// Tries to get the declared enumeration instance that matches the specified name without allocating a string.
        /// </summary>
        /// <param name="name">The characters of the name to match.</param>
        /// <param name="enumeration">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static bool TryParseName(ReadOnlySpan<char> name, [MaybeNullWhen(false)] out TEnum enumeration) {
            return TryParseName(name, false, out enumeration);
        }

        /// <summary>
        /// Tries to get the declared enumeration instance that matches the specified name without allocating a string.
        /// </summary>
        /// <param name="name">The characters of the name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <param name="enumeration">The matching enumeration instance.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static bool TryParseName(ReadOnlySpan<char> name, bool ignoreCase, [MaybeNullWhen(false)] out TEnum enumeration) {
            return GetLookup().TryGetByName(name, ignoreCase, out enumeration);
        }

#endif
        /// <summary>
        /// Determines whether the specified name matches a declared enumeration.
        /// </summary>
        /// <param name="name">The name to match.</param>
        /// <param name="ignoreCase"><see langword="true" /> to ignore name casing; otherwise, <see langword="false" />.</param>
        /// <returns><see langword="true" /> if a matching enumeration exists; otherwise, <see langword="false" />.</returns>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="name" />.</exception>
        public static bool IsDefinedName(string name, bool ignoreCase = false) {
            return TryParseName(name, ignoreCase, out _);
        }

        /// <summary>
        /// Gets the underlying value type of the enumeration.
        /// </summary>
        /// <returns>The runtime type represented by <typeparamref name="TValue" />.</returns>
        public static Type GetValueType() {
            return typeof(TValue);
        }

        private static EnumerationLookup GetLookup() {
            return Volatile.Read(ref lookup) ?? InitializeLookup();
        }

        private static EnumerationLookup InitializeLookup() {
            lock (SyncRoot) {
                // 探索失敗時不寫入快取，讓型別初始化完成後的下一次呼叫可以重新探索
                EnumerationLookup result = Volatile.Read(ref lookup) ?? new EnumerationLookup(GetDeclaredEnumerations());
                Volatile.Write(ref lookup, result);
                return result;
            }
        }

        private static TEnum[] GetDeclaredEnumerations() {
            IEnumerable<PropertyInfo> props = typeof(TEnum)
                .GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .OrderBy(x => x.MetadataToken);

            List<TEnum> instances = new List<TEnum>();
            foreach (PropertyInfo prop in props) {
                if (!prop.CanRead
                    || prop.GetIndexParameters().Length != 0
                    || prop.IsDefined(typeof(EnumerationIgnoreAttribute), false)
                ) {
                    continue;
                }

                object? value = prop.GetValue(null, null);

                if (value is null) {
                    ThrowIfUninitializedMember(prop);
                    continue;
                }

                // 別名屬性（例如 Default => Red）回傳既有實例，以參考相等去重並保留第一次宣告的順序
                if (value is TEnum instance && !instances.Any(x => ReferenceEquals(x, instance))) {
                    instances.Add(instance);
                }
            }

            return instances.ToArray();
        }

        private static void ThrowIfUninitializedMember(PropertyInfo property) {
            if (!typeof(TEnum).IsAssignableFrom(property.PropertyType) || IsNullableAnnotated(property)) {
                return;
            }

            throw new InvalidOperationException(
                $"The static property '{typeof(TEnum).FullName}.{property.Name}' returned null while discovering enumeration members. "
                + $"This usually means the members of '{typeof(TEnum).Name}' were accessed (for example through GetAll, Parse or TryParse) "
                + "before its static initialization completed. Declare every enumeration member before static members that use them, "
                + $"or initialize those static members lazily. A property that intentionally returns null must declare a nullable type "
                + $"or be marked with {nameof(EnumerationIgnoreAttribute)}."
            );
        }

        private static bool IsNullableAnnotated(PropertyInfo property) {
            byte? flag = GetNullableFlag(property.CustomAttributes, NullableAttributeName);

            for (Type? type = property.DeclaringType; flag is null && type is not null; type = type.DeclaringType) {
                flag = GetNullableFlag(type.CustomAttributes, NullableContextAttributeName);
            }

            return flag == NullableAnnotatedFlag;
        }

        private static byte? GetNullableFlag(IEnumerable<CustomAttributeData> attributes, string attributeName) {
            foreach (CustomAttributeData attribute in attributes) {
                if (attribute.AttributeType.FullName != attributeName || attribute.ConstructorArguments.Count != 1) {
                    continue;
                }

                object? argument = attribute.ConstructorArguments[0].Value;
                if (argument is byte flag) {
                    return flag;
                }

                if (argument is IReadOnlyList<CustomAttributeTypedArgument> flags
                    && flags.Count > 0
                    && flags[0].Value is byte firstFlag
                ) {
                    return firstFlag;
                }
            }

            return null;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object? obj) {
            if (obj is TEnum enumeration) {
                return Equals(enumeration);
            } else if (obj is TValue value) {
                return Equals(value);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public bool Equals(TEnum? other) {
            if (other is null) {
                return false;
            }

            return Value.Equals(other.Value);
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="value">The other.</param>
        /// <returns><c>true</c> If the current object value is equal to other parameters; otherwise, <c>false</c>.</returns>
        protected virtual bool Equals(TValue value) {
            // 避免其他繼承 EnumerableBase<TEnum, TValue> 因隱含轉換跑進來，所以用 protected
            return Value.Equals(value);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The hash code of <see cref="Value" />.</returns>
        /// <remarks>
        /// The hash code equals the hash code of <see cref="Value" /> so that an enumeration and its underlying value,
        /// which compare equal through <see cref="Equals(object)" />, also share a hash code.
        /// </remarks>
        public override int GetHashCode() {
            return Value is null ? 0 : EqualityComparer<TValue>.Default.GetHashCode(Value);
        }

        /// <inheritdoc/>
        public int CompareTo(object? obj) {
            if (obj is TEnum enumeration) {
                return CompareTo(enumeration);
            } else if (obj is TValue value) {
                return CompareTo(value);
            }

            throw new InvalidCastException();
        }

        /// <inheritdoc/>
        public virtual int CompareTo(TEnum? other) {
            if (other is null) {
                return 1;
            }

            return Value.CompareTo(other.Value);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings:
        /// Value
        /// Meaning
        /// Less than zero
        /// This instance precedes <paramref name="other" /> in the sort order.
        /// Zero
        /// This instance occurs in the same position in the sort order as <paramref name="other" />.
        /// Greater than zero
        /// This instance follows <paramref name="other" /> in the sort order.
        /// </returns>
        public virtual int CompareTo(TValue other) {
            return Value.CompareTo(other);
        }

        /// <summary>
        /// Returns the declared enumeration instance that a deserialized copy represents.
        /// </summary>
        /// <param name="context">The source of the serialized stream.</param>
        /// <returns>The declared instance with the same <see cref="Value" /> and <see cref="Name" />.</returns>
        /// <exception cref="SerializationException">No declared enumeration matches the deserialized value.</exception>
#pragma warning disable SYSLIB0050
        object IObjectReference.GetRealObject(StreamingContext context) {
#pragma warning restore SYSLIB0050
            TEnum? valueMatch = null;
            EqualityComparer<TValue> comparer = EqualityComparer<TValue>.Default;

            foreach (TEnum member in GetLookup().Members) {
                if (!comparer.Equals(member.Value, Value)) {
                    continue;
                }

                // 重複 Value 時以 Name 區分，維持反序列化前的參考身分
                if (string.Equals(member.Name, Name, StringComparison.Ordinal)) {
                    return member;
                }

                valueMatch ??= member;
            }

            return valueMatch ?? throw new SerializationException(
                $"No declared enumeration of '{typeof(TEnum).FullName}' matches the deserialized value '{Value}'."
            );
        }

        /// <summary>Converts to string.</summary>
        /// <returns>The name.</returns>
        public override string ToString() {
            return Name;
        }

        /// <summary>Performs an implicit conversion from <see cref="EnumerationBase{TEnum, TValue}" /> to <c>TValue</c>.</summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TValue(EnumerationBase<TEnum, TValue> enumeration) {
            return enumeration.Value;
        }

        /// <summary>Performs an explicit conversion from <c>TValue</c> to <see cref="EnumerationBase{TEnum, TValue}" />.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        /// <exception cref="InvalidCastException">No declared enumeration matches <paramref name="value" />.</exception>
        /// <exception cref="InvalidOperationException">More than one declared enumeration matches <paramref name="value" />.</exception>
        public static explicit operator EnumerationBase<TEnum, TValue>(TValue value) {
            return TryParse(value, out TEnum? enumeration)
                ? enumeration
                : throw new InvalidCastException($"Could not convert '{value}' to '{typeof(TEnum).FullName}' because no declared enumeration has that value.");
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            return left is null ? right is null : left.Equals(right as TEnum);
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.Equals(right) == true;
        }

        /// <summary>Implements the operator ==.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.Equals(left) == true;
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            return !(left == right);
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return !(left == right);
        }

        /// <summary>Implements the operator !=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return !(left == right);
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }
            return left.CompareTo(right) > 0;
        }

        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) > 0;
        }


        /// <summary>Implements the operator &gt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) < 0;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) < 0;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) < 0;
        }

        /// <summary>Implements the operator &lt;.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) > 0;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) >= 0;
        }

        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) >= 0;
        }


        /// <summary>Implements the operator &gt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) <= 0;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) <= 0;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) <= 0;
        }

        /// <summary>Implements the operator &lt;=.</summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) >= 0;
        }
    }
}
