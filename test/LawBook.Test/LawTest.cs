using System;
using Xunit;

namespace LawBook.Test
{
    public class LawTest
    {
        private string _defaultMessage;

        public LawTest()
        {
            _defaultMessage = "Throw error Message!";
        }

        [Fact]
        public void ObjectsMustNotBeEqualsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = new DateTime(2022, 1, 1);

            var exception = Record.Exception(() => Law.MustNotBeEquals(today, today1, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void ObjectsMustNotBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = DateTime.Today;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(today, today1, _defaultMessage));
        }

        [Fact]
        public void ObjectsMustBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = new DateTime(2022, 1, 1);

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(today, today1, _defaultMessage));
        }

        [Fact]
        public void ObjectsMustBeEqualsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = DateTime.Today;

            var exception = Record.Exception(() => Law.MustBeEquals(today, today1, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringsMustBeEqualsThrowsTest()
        {
            string foo = "Foo";
            string bar = "Bar";

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(foo, bar, _defaultMessage));
        }

        [Fact]
        public void StringsMustBeEqualsTest()
        {
            string foo = "Foo";
            string bar = "Foo";

            var exception = Record.Exception(() => Law.MustBeEquals(foo, bar, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringsMustBeLowerLengthThrowsTest()
        {
            string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeLowerLength(foo, 3, _defaultMessage));
        }

        [Fact]
        public void StringsMustBeLowerLengthTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeLowerLength(foo, 10, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringsMustBeInBetweensLengthThrowsTest()
        {
            string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeInBetweensLength(foo, 3, 5, _defaultMessage));
        }

        [Fact]
        public void StringsMustBeInBetweensLengthTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeInBetweensLength(foo, 5, 10, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringsMustBeNotEmptyThrowsTest()
        {
            string foo = string.Empty;

            Assert.Throws<GuiltyException>(() => Law.MustBeNotEmpty(foo, _defaultMessage));
        }

        [Fact]
        public void StringsMustBeNotEmptyTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeNotEmpty(foo, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringsMustBeNotNullThrowsTest()
        {

            Assert.Throws<GuiltyException>(() => Law.MustBeNotNull(null, _defaultMessage));
        }

        [Fact]
        public void StringsMustBeNotNullTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeNotNull(foo, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void DoubleMustNotBeInBetweensThrowsTest()
        {
            double amount = 0.5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0, 2.0, _defaultMessage));
        }

        [Fact]
        public void DoubleMustNotBeInBetweensTest()
        {
            double amount = 2.25;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0, 2.5, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void FloatMustNotBeInBetweensThrowsTest()
        {
            float amount = 0.5f;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0f, 2.0f, _defaultMessage));
        }

        [Fact]
        public void FloatMustNotBeInBetweensTest()
        {
            float amount = 2.25f;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0f, 2.5f, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void IntMustNotBeInBetweensThrowsTest()
        {
            int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        [Fact]
        public void IntMustNotBeInBetweensTest()
        {
            int amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void LongMustNotBeInBetweensThrowsTest()
        {
            long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        [Fact]
        public void LongMustNotBeInBetweensTest()
        {
            long amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void DecimalMustNotBeInBetweensThrowsTest()
        {
            decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0M, 2.0M, _defaultMessage));
        }

        [Fact]
        public void DecimalMustNotBeInBetweensTest()
        {
            decimal amount = 225.0M;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200.0M, 250.0M, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void LongMustBeHigherThrowsTest()
        {
            long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        [Fact]
        public void LongMustBeHigherTest()
        {
            long amount = 5;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void DoubleMustBeHigherThrowsTest()
        {
            double amount = 5.0;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0, _defaultMessage));
        }

        [Fact]
        public void DoubleMustBeHigherTest()
        {
            double amount = 5.0;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void DecimalMustBeHigherThrowsTest()
        {
            decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0M, _defaultMessage));
        }

        [Fact]
        public void DecimalMustBeHigherTest()
        {
            decimal amount = 5.0M;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0M, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void IntMustBeHigherThrowsTest()
        {
            int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        [Fact]
        public void IntMustBeHigherTest()
        {
            int amount = 5;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void MustBeTrueThrowsTest()
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeTrue(false, _defaultMessage));
        }

        [Fact]
        public void MustBeTrueTest()
        {

            var exception = Record.Exception(() => Law.MustBeTrue(true, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void MustBeFalseThrowsTest()
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeFalse(true, _defaultMessage));
        }

        [Fact]
        public void MustBeFalseTest()
        {

            var exception = Record.Exception(() => Law.MustBeFalse(false, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringMustBeContainedThrowsTest()
        {
            string[] options = new string[]
            {
                "hello",
                "world"
            };

            Assert.Throws<GuiltyException>(() => Law.MustBeContained("foo", options, _defaultMessage));
        }

        [Fact]
        public void StringMustBeContainedTest()
        {
            string[] options = new string[]
            {
                "hello",
                "world"
        };

            var exception = Record.Exception(() => Law.MustBeContained("hello", options, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void StringMustNotBeContainedThrowsTest()
        {
            string[] options = new string[]
            {
                "hello",
                "world"
            };

            Assert.Throws<GuiltyException>(() => Law.MustNotBeContained("hello", options, _defaultMessage));
        }

        [Fact]
        public void StringMustNotBeContainedTest()
        {
            string[] options = new string[]
            {
                "hello",
                "world"
        };

            var exception = Record.Exception(() => Law.MustNotBeContained("foo", options, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void IntMustBeContainedThrowsTest()
        {
            int[] options = new int[]
            {
                2,
                4
            };

            Assert.Throws<GuiltyException>(() => Law.MustBeContained(1, options, _defaultMessage));
        }

        [Fact]
        public void IntMustBeContainedTest()
        {
            int[] options = new int[]
            {
                2,
                4
            };

            var exception = Record.Exception(() => Law.MustBeContained(4, options, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void IntMustNotBeContainedThrowsTest()
        {
            int[] options = new int[]
            {
                2,
                4
            };

            var exception = Record.Exception(() => Law.MustNotBeContained(4, options, _defaultMessage));

            Assert.Null(exception);
        }

        [Fact]
        public void IntMustNotBeContainedTest()
        {
            int[] options = new int[]
            {
                2,
                4
            };

            Assert.Throws<GuiltyException>(() => Law.MustNotBeContained(1, options, _defaultMessage));
        }
    }
}