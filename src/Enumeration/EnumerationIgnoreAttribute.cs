using System;

namespace CloudyWing.Enumeration {
    /// <summary>
    /// Excludes a public static property from enumeration member discovery.
    /// </summary>
    /// <remarks>
    /// Apply this attribute to alias or helper properties that return a <c>TEnum</c> instance but should not be returned by
    /// <see cref="Abstractions.EnumerationBase{TEnum, TValue}.GetAll" /> or matched by the lookup members.
    /// The getter of an ignored property is not invoked during discovery.
    /// </remarks>
    /// <example>
    /// <code language="csharp">
    /// public sealed class Color : EnumerationBase&lt;Color, int&gt; {
    ///     public static Color Red { get; } = new Color(1, nameof(Red));
    ///
    ///     public static Color Green { get; } = new Color(2, nameof(Green));
    ///
    ///     [EnumerationIgnore]
    ///     public static Color Preferred => Settings.UseRed ? Red : Green;
    ///
    ///     private Color(int value, string name) : base(value, name) { }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class EnumerationIgnoreAttribute : Attribute {
    }
}
