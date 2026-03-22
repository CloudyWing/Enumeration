using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests {
    internal class SwitchStatementTests {
        [Test]
        public void WhenThen_MatchingEnumerationInCollection_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One, BasicIntEnumeration.Two)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void WhenThen_NonMatchingEnumerationInCollection_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One, BasicIntEnumeration.Two)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void WhenThen_TrueCondition_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(true)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void WhenThen_FalseCondition_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(false)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void WhenThen_FirstMatchingSecondMatching_ExecutesFirstAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.One)
                .Then(() => result = 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void WhenThen_FirstNonMatchingSecondMatching_ExecutesSecondAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Two;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void WhenThen_BothNonMatching_DoesNotExecuteAnyAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2);

            Assert.That(result, Is.Zero);
        }

        [Test]
        public void AndWhenThen_WhenMatchingAndConditionTrue_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .AndWhen(true)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void AndWhenThen_WhenMatchingAndConditionFalse_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .AndWhen(false)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void AndWhenThen_WhenNonMatchingAndConditionTrue_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .AndWhen(true)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void AndWhenThen_WhenNonMatchingAndConditionFalse_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .AndWhen(false)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void OrWhenThen_WhenMatchingOrConditionTrue_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .OrWhen(true)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void OrWhenThen_WhenNonMatchingOrConditionTrue_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .OrWhen(true)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void OrWhenThen_WhenMatchingOrConditionFalse_ExecutesAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .OrWhen(false)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.True);
        }

        [Test]
        public void OrWhenThen_WhenNonMatchingOrConditionFalse_DoesNotExecuteAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .OrWhen(false)
                .Then(() => isExecuted = true);

            Assert.That(isExecuted, Is.False);
        }

        [Test]
        public void Default_WhenThenMatching_ExecutesWhenThenAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .Default(() => result = 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Default_WhenThenNonMatching_ExecutesDefaultAction() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2)
                .Default(() => result = 3);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
