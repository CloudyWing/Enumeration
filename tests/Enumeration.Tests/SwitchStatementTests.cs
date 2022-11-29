using CloudyWing.Enumeration.Tests.Enumerations;

namespace CloudyWing.Enumeration.Tests {
    internal class SwitchStatementTests {
        [Test]
        public void WhenThen_When集合符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One, BasicIntEnumeration.Two)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void WhenThen_When集合不符合_未更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One, BasicIntEnumeration.Two)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void WhenThen_When條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(true)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void WhenThen_When條件判斷不符合_未更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(false)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void WhenThen_第一組WhenThen符合且第二組WhenThen符合_結果為第一組設定的值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.One)
                .Then(() => result = 2);

            result.Should().Be(1);
        }

        [Test]
        public void WhenThen_第一組WhenThen不符合且第二組WhenThen符合_結果為第二組設定的值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Two;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2);

            result.Should().Be(2);
        }

        [Test]
        public void WhenThen_第一組WhenThen和第二組WhenThen都不符合_未設定值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2);

            result.Should().Be(0);
        }

        [Test]
        public void AndWhenThen_When符合AndWhen條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .AndWhen(true)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void AndWhenThen_When符合AndWhen條件判斷不符合_未更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .AndWhen(false)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void AndWhenThen_When不符合AndWhen條件判斷符合_未更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .AndWhen(true)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void AndWhenThen_When不符合AndWhen條件判斷不符合_未更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .AndWhen(false)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void OrWhenThen_When符合OrWhen條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .OrWhen(true)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void OrWhenThen_When不符合OrWhen條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .OrWhen(true)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void OrWhenThen_When符合OrWhen不條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.Zero)
                .OrWhen(false)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeTrue();
        }

        [Test]
        public void OrWhenThen_When不符合OrWhen不條件判斷符合_有更改值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            bool isExecuted = false;

            enumeration.When(BasicIntEnumeration.One)
                .OrWhen(false)
                .Then(() => isExecuted = true);

            isExecuted.Should().BeFalse();
        }

        [Test]
        public void Default_WhenThen符合_結果為WhenThen設定的值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.One;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .Default(() => result = 2);

            result.Should().Be(1);
        }

        [Test]
        public void Default_WhenThen不符合_結果為Default設定的值() {
            BasicIntEnumeration enumeration = BasicIntEnumeration.Zero;
            int result = 0;

            enumeration
                .When(BasicIntEnumeration.One)
                .Then(() => result = 1)
                .When(BasicIntEnumeration.Two)
                .Then(() => result = 2)
                .Default(() => result = 3);

            result.Should().Be(3);
        }
    }
}
