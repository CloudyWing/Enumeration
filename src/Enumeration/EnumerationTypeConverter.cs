using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;
using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration {
    /// <summary>
    /// Provides helpers that register <see cref="EnumerationTypeConverter{TEnum, TValue}" /> for enumeration types.
    /// </summary>
    /// <remarks>
    /// Registration uses <see cref="TypeDescriptor.AddAttributes(Type, Attribute[])" />, so the enumeration type does not need to be changed.
    /// Components that resolve converters through <see cref="TypeDescriptor" />, such as ASP.NET Core model binding and
    /// <c>Microsoft.Extensions.Configuration</c> binding, can then convert text to the enumeration.
    /// </remarks>
    public static class EnumerationTypeConverter {
        /// <summary>
        /// Registers <see cref="EnumerationTypeConverter{TEnum, TValue}" /> as the type converter of <typeparamref name="TEnum" />.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <typeparam name="TValue">The underlying value type.</typeparam>
        /// <remarks>
        /// Calling this method more than once for the same enumeration type registers the converter only once.
        /// Call it during application startup, before the converter is first resolved.
        /// </remarks>
        public static void Register<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] TEnum, TValue>()
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            Registration<TEnum, TValue>.EnsureRegistered();
        }

        private static class Registration<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] TEnum, TValue>
            where TEnum : EnumerationBase<TEnum, TValue>
            where TValue : IComparable {
            private static readonly object SyncRoot = new object();
            private static bool isRegistered;

            public static void EnsureRegistered() {
                lock (SyncRoot) {
                    if (isRegistered) {
                        return;
                    }

                    TypeDescriptor.AddAttributes(
                        typeof(TEnum),
                        new TypeConverterAttribute(typeof(EnumerationTypeConverter<TEnum, TValue>))
                    );
                    isRegistered = true;
                }
            }
        }
    }
}
