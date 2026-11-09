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
    

        [Test]
        public void When_PreviousBranchExecuted_DoesNotEvaluatePredicate() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int predicateCalls = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => { })
                .When(() => {
                    predicateCalls++;
                    return true;
                })
                .Then(() => { })
                .Default(() => { });

            Assert.That(predicateCalls, Is.Zero);
        }

        [Test]
        public void AndWhen_PreviousBranchExecuted_DoesNotEvaluatePredicate() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int predicateCalls = 0;

            enumeration
                .When(true)
                .Then(() => { })
                .When(BasicIntEnumeration.One)
                .AndWhen(() => {
                    predicateCalls++;
                    return true;
                })
                .Then(() => { });

            Assert.That(predicateCalls, Is.Zero);
        }

        [Test]
        public void Default_LongChainWithoutMatch_ExecutesDefaultOnce() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            int defaultCalls = 0;
            IThenStatement<BasicIntEnumeration, int> statement = enumeration.When(false).Then(() => { });

            for (int i = 0; i < 10_000; i++) {
                statement = statement.When(BasicIntEnumeration.One).OrWhen(false).Then(() => { });
            }

            statement.Default(() => defaultCalls++);

            Assert.That(defaultCalls, Is.EqualTo(1));
        }

        [Test]
        public void Then_ReadmeExample_ExecutesFirstMatchingBranchOnly() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Two;
            List<int> executedBranches = [];

            enumeration.When(BasicIntEnumeration.Zero).Then(() => executedBranches.Add(1))
                .When(BasicIntEnumeration.Zero, BasicIntEnumeration.One).Then(() => executedBranches.Add(2))
                .When(false).Then(() => executedBranches.Add(3))
                .When(BasicIntEnumeration.Zero).AndWhen(true).Then(() => executedBranches.Add(4))
                .When(BasicIntEnumeration.Zero).OrWhen(BasicIntEnumeration.One, BasicIntEnumeration.Two).Then(() => executedBranches.Add(5))
                .Default(() => executedBranches.Add(6));

            Assert.That(executedBranches, Is.EqualTo(new[] { 5 }).AsCollection);
        }
}
}
