using System;
using System.Runtime.Serialization;

namespace CloudyWing.Enumeration {
    /// <summary>The enumeration not found exception.</summary>m>
    /// <seealso cref="Exception" />
    public class EnumerationNotFoundException : Exception {
        /// <summary>Initializes a new instance of the <see cref="EnumerationNotFoundException" /> class.</summary>
        public EnumerationNotFoundException() : this($"Could not find enumeration.") { }

        /// <summary>Initializes a new instance of the <see cref="EnumerationNotFoundException" /> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public EnumerationNotFoundException(string message) : base(message) { }

        /// <summary>Initializes a new instance of the <see cref="EnumerationNotFoundException" /> class.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (<span class="keyword"><span class="languageSpecificText"><span class="cs">null</span><span class="vb">Nothing</span><span class="cpp">nullptr</span></span></span><span class="nu">a null reference (<span class="keyword">Nothing</span> in Visual Basic)</span> in Visual Basic) if no inner exception is specified.
        /// </param>
        public EnumerationNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>Initializes a new instance of the <see cref="EnumerationNotFoundException" /> class.</summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo">SerializationInfo</see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext">StreamingContext</see> that contains contextual information about the source or destination.</param>
        protected EnumerationNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
