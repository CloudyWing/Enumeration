namespace CloudyWing.Enumeration.Json {
    /// <summary>
    /// Specifies how an enumeration is written to and read from JSON.
    /// </summary>
    public enum EnumerationJsonFormat {
        /// <summary>
        /// Uses the underlying value, serialized with the converter of the value type.
        /// </summary>
        Value = 0,

        /// <summary>
        /// Uses the name as a JSON string.
        /// </summary>
        Name = 1
    }
}
