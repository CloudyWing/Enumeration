using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests.Abstractions {
    internal class UShortEnumerationTests {
        [Test]
        public void ImplicitOperator_ToInt() {
            int act = NumericUShortEnumeration.One;
            int result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToUInt() {
            uint act = NumericUShortEnumeration.One;
            uint result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToLong() {
            long act = NumericUShortEnumeration.One;
            long result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToULong() {
            ulong act = NumericUShortEnumeration.One;
            ulong result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToFloat() {
            float act = NumericUShortEnumeration.One;
            float result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDouble() {
            double act = NumericUShortEnumeration.One;
            double result = 1;
            act.Should().Be(result);
        }

        [Test]
        public void ImplicitOperator_ToDecimal() {
            decimal act = NumericUShortEnumeration.One;
            decimal result = 1;
            act.Should().Be(result);
        }
    }
}
