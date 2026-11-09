using CloudyWing.Enumeration.Abstractions;

namespace CloudyWing.Enumeration.Tests.Enumerations {
    internal class ReentrantIntEnumeration : ConvertibleEnumeration<ReentrantIntEnumeration, int> {
        private static readonly Exception? initializationException;

        static ReentrantIntEnumeration() {
            First = new ReentrantIntEnumeration(1, nameof(First));
            initializationException = CaptureDiscoveryException();
            Second = new ReentrantIntEnumeration(2, nameof(Second));
        }

        private ReentrantIntEnumeration(int value, string name) : base(value, name) { }

        public static ReentrantIntEnumeration First { get; }

        public static ReentrantIntEnumeration Second { get; }

        public static Exception? InitializationException => initializationException;

        private static Exception? CaptureDiscoveryException() {
            try {
                _ = GetAll().ToList();
                return null;
            } catch (InvalidOperationException ex) {
                return ex;
            }
        }
    }
}
