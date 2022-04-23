/*****************************************************************************************************************
 * You may amend and distribute as you like, but don't remove this header!
 * 
 * See https://github.com/TheLe0/LawBook for details.
 *
 * MIT License
 * 
 * Copyright (c) 2022 Leonardo Bertele Tosin
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial 
 * portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
 * LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 ****************************************************************************************************************/

using System;
using Xunit;

namespace LawBook.Test
{
    public class LawTest
    {
        /// <summary>
        /// Default message used to pass for the thrown exception.
        /// </summary>
        private string _defaultMessage;

        /// <summary>
        /// Initializes the test class.
        /// </summary>
        public LawTest()
        {
            _defaultMessage = "Throw error Message!";
        }

        /// <summary>
        /// Validate if two objects are distinct, success case.
        /// </summary>
        [Fact]
        public void ObjectsMustNotBeEqualsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = new DateTime(2022, 1, 1);

            var exception = Record.Exception(() => Law.MustNotBeEquals(today, today1, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if two objects are distinct, fail case.
        /// </summary>
        [Fact]
        public void ObjectsMustNotBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = DateTime.Today;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(today, today1, _defaultMessage));
        }

        /// <summary>
        /// Validate if two objects are the same, fail case.
        /// </summary>
        [Fact]
        public void ObjectsMustBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = new DateTime(2022, 1, 1);

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(today, today1, _defaultMessage));
        }

        /// <summary>
        /// Validate if two objects are the same, success case.
        /// </summary>
        [Fact]
        public void ObjectsMustBeEqualsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = DateTime.Today;

            var exception = Record.Exception(() => Law.MustBeEquals(today, today1, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if two strings are the same, fail case.
        /// </summary>
        [Fact]
        public void StringsMustBeEqualsThrowsTest()
        {
            string foo = "Foo";
            string bar = "Bar";

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(foo, bar, _defaultMessage));
        }

        /// <summary>
        /// Validate if two strings are the same, success case.
        /// </summary>
        [Fact]
        public void StringsMustBeEqualsTest()
        {
            string foo = "Foo";
            string bar = "Foo";

            var exception = Record.Exception(() => Law.MustBeEquals(foo, bar, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a string length is lower than defined, fail case.
        /// </summary>
        [Fact]
        public void StringMustBeLowerLengthThrowsTest()
        {
            string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeLowerLength(foo, 3, _defaultMessage));
        }

        /// <summary>
        /// Validate if a string length is lower than defined, success case.
        /// </summary>
        [Fact]
        public void StringMustBeLowerLengthTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeLowerLength(foo, 10, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a string length is between an interval than defined, fail case.
        /// </summary>
        [Fact]
        public void StringMustBeInBetweensLengthThrowsTest()
        {
            string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeInBetweensLength(foo, 3, 5, _defaultMessage));
        }

        /// <summary>
        /// Validate if a string length is between an interval than defined, success case.
        /// </summary>
        [Fact]
        public void StringMustBeInBetweensLengthTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeInBetweensLength(foo, 5, 10, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a string is empty, fail case.
        /// </summary>
        [Fact]
        public void StringMustBeNotEmptyThrowsTest()
        {
            string foo = string.Empty;

            Assert.Throws<GuiltyException>(() => Law.MustBeNotEmpty(foo, _defaultMessage));
        }

        /// <summary>
        /// Validate if a string is empty, success case.
        /// </summary>
        [Fact]
        public void StringMustBeNotEmptyTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeNotEmpty(foo, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if an object is null, fail case.
        /// </summary>
        [Fact]
        public void ObjectMustBeNotNullThrowsTest()
        {

            Assert.Throws<GuiltyException>(() => Law.MustBeNotNull(null, _defaultMessage));
        }

        /// <summary>
        /// Validate if an object is null, success case.
        /// </summary>
        [Fact]
        public void ObjectMustBeNotNullTest()
        {
            string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeNotNull(foo, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a double number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeInBetweensThrowsTest()
        {
            double amount = 0.5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0, 2.0, _defaultMessage));
        }

        /// <summary>
        /// Validate if a double number is between an interval, success case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeInBetweensTest()
        {
            double amount = 2.25;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0, 2.5, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a float number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeInBetweensThrowsTest()
        {
            float amount = 0.5f;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0f, 2.0f, _defaultMessage));
        }

        /// <summary>
        /// Validate if a float number is between an interval, success case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeInBetweensTest()
        {
            float amount = 2.25f;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0f, 2.5f, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if an int number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void IntMustNotBeInBetweensThrowsTest()
        {
            int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        /// <summary>
        /// Validate if an int number is between an interval, success case.
        /// </summary>
        [Fact]
        public void IntMustNotBeInBetweensTest()
        {
            int amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a long number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void LongMustNotBeInBetweensThrowsTest()
        {
            long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        /// <summary>
        /// Validate if a long number is between an interval, success case.
        /// </summary>
        [Fact]
        public void LongMustNotBeInBetweensTest()
        {
            long amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a decimal number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeInBetweensThrowsTest()
        {
            decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0M, 2.0M, _defaultMessage));
        }

        /// <summary>
        /// Validate if a decimal number is between an interval, success case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeInBetweensTest()
        {
            decimal amount = 225.0M;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200.0M, 250.0M, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a long number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void LongMustBeHigherThrowsTest()
        {
            long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        /// <summary>
        /// Validate if a long number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void LongMustBeHigherTest()
        {
            long amount = 5;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a double number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustBeHigherThrowsTest()
        {
            double amount = 5.0;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0, _defaultMessage));
        }

        /// <summary>
        /// Validate if a double number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void DoubleMustBeHigherTest()
        {
            double amount = 5.0;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a decimal number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustBeHigherThrowsTest()
        {
            decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0M, _defaultMessage));
        }

        /// <summary>
        /// Validate if a decimal number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void DecimalMustBeHigherTest()
        {
            decimal amount = 5.0M;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0M, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if an int number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void IntMustBeHigherThrowsTest()
        {
            int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        /// <summary>
        /// Validate if an int number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void IntMustBeHigherTest()
        {
            int amount = 5;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a boolean expression is true, fail case.
        /// </summary>
        [Fact]
        public void MustBeTrueThrowsTest()
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeTrue(false, _defaultMessage));
        }

        /// <summary>
        /// Validate if a boolean expression is true, success case.
        /// </summary>
        [Fact]
        public void MustBeTrueTest()
        {

            var exception = Record.Exception(() => Law.MustBeTrue(true, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a boolean expression is false, fail case.
        /// </summary>
        [Fact]
        public void MustBeFalseThrowsTest()
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeFalse(true, _defaultMessage));
        }

        /// <summary>
        /// Validate if a boolean expression is false, success case.
        /// </summary>
        [Fact]
        public void MustBeFalseTest()
        {

            var exception = Record.Exception(() => Law.MustBeFalse(false, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a string value is contained on a list, fail case.
        /// </summary>
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

        /// <summary>
        /// Validate if a string value is contained on a list, success case.
        /// </summary>
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

        /// <summary>
        /// Validate if a string value is not contained on a list, fail case.
        /// </summary>
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

        /// <summary>
        /// Validate if a string value is not contained on a list, success case.
        /// </summary>
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

        /// <summary>
        /// Validate if an int number is contained on a list, fail case.
        /// </summary>
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

        /// <summary>
        /// Validate if an int number is contained on a list, success case.
        /// </summary>
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

        /// <summary>
        /// Validate if an int number is not contained on a list, success case.
        /// </summary>
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

        /// <summary>
        /// Validate if an int number is not contained on a list, fail case.
        /// </summary>
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