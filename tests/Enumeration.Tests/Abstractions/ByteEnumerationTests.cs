using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class ByteEnumerationTests {
        [Test]
        public void ImplicitOperator_ToShort() {
            short act = NumericByteEnumeration.One;
            short result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToInt() {
            int act = NumericByteEnumeration.One;
            int result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToUInt() {
            uint act = NumericByteEnumeration.One;
            uint result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericByteEnumeration.One;
            long result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToULong() {
            ulong act = NumericByteEnumeration.One;
            ulong result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericByteEnumeration.One;
            float result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericByteEnumeration.One;
            double result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericByteEnumeration.One;
            decimal result = 1;
            act.Should().Be(result);
        }
    }
}
