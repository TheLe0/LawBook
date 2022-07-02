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
        private readonly string _defaultMessage;

        /// <summary>
        /// Initializes the test class.
        /// </summary>
        public LawTest()
        {
            _defaultMessage = "Throw error Message!";
        }

        /// <summary>
        /// Validates if two objects are distinct, success case.
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
        /// Validates if two objects are distinct, fail case.
        /// </summary>
        [Fact]
        public void ObjectsMustNotBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = DateTime.Today;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(today, today1, _defaultMessage));
        }

        /// <summary>
        /// Validates if two objects are the same, fail case.
        /// </summary>
        [Fact]
        public void ObjectsMustBeEqualsThrowsTest()
        {
            DateTime today = DateTime.Today;
            DateTime today1 = new DateTime(2022, 1, 1);

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(today, today1, _defaultMessage));
        }

        /// <summary>
        /// Validates if two objects are the same, success case.
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
        /// Validates if two integer numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void IntegersMustBeEqualsThrowsTest()
        {
            const int number1 = 1;
            const int number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two integer numbers are the same, success case.
        /// </summary>
        [Fact]
        public void IntegersMustBeEqualsTest()
        {
            const int number1 = 1;
            const int number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two integer numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void IntegersMustNotBeEqualsThrowsTest()
        {
            const int number1 = 1;
            const int number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two integer numbers are the same, success case.
        /// </summary>
        [Fact]
        public void IntegersMustNotBeEqualsTest()
        {
            const int number1 = 1;
            const int number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two unsigned int numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void UIntegersMustBeEqualsThrowsTest()
        {
            const uint number1 = 1;
            const uint number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two unsigned int numbers are the same, success case.
        /// </summary>
        [Fact]
        public void UIntegersMustBeEqualsTest()
        {
            const uint number1 = 1;
            const uint number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two unsigned int numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void UIntegersMustNotBeEqualsThrowsTest()
        {
            const uint number1 = 1;
            const uint number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two unsigned int numbers are the same, success case.
        /// </summary>
        [Fact]
        public void UIntegersMustNotBeEqualsTest()
        {
            const uint number1 = 1;
            const uint number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two byte numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void BytesMustBeEqualsThrowsTest()
        {
            const byte number1 = 1;
            const byte number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two byte numbers are the same, success case.
        /// </summary>
        [Fact]
        public void BytesMustBeEqualsTest()
        {
            const byte number1 = 1;
            const byte number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two byte numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void BytesMustNotBeEqualsThrowsTest()
        {
            const byte number1 = 1;
            const byte number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two byte numbers are the same, success case.
        /// </summary>
        [Fact]
        public void BytesMustNotBeEqualsTest()
        {
            const byte number1 = 1;
            const byte number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two short byte numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void SbyteMustBeEqualsThrowsTest()
        {
            const sbyte number1 = 1;
            const sbyte number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two short byte numbers are the same, success case.
        /// </summary>
        [Fact]
        public void SbyteMustBeEqualsTest()
        {
            const sbyte number1 = 1;
            const sbyte number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two short byte numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void SbyteMustNotBeEqualsThrowsTest()
        {
            const sbyte number1 = 1;
            const sbyte number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two short byte numbers are the same, success case.
        /// </summary>
        [Fact]
        public void SbyteMustNotBeEqualsTest()
        {
            const sbyte number1 = 1;
            const sbyte number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two short numbers are the same, success case.
        /// </summary>
        [Fact]
        public void ShortMustNotBeEqualsTest()
        {
            const short number1 = 1;
            const short number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two short numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void ShortMustBeEqualsThrowsTest()
        {
            const short number1 = 1;
            const short number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two short numbers are the same, success case.
        /// </summary>
        [Fact]
        public void ShortMustBeEqualsTest()
        {
            const short number1 = 1;
            const short number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two short numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void ShortMustNotBeEqualsThrowsTest()
        {
            const short number1 = 1;
            const short number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two unsigned short numbers are the same, success case.
        /// </summary>
        [Fact]
        public void UShortMustNotBeEqualsTest()
        {
            const ushort number1 = 1;
            const ushort number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two unsigned short numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void UShortMustBeEqualsThrowsTest()
        {
            const ushort number1 = 1;
            const ushort number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two unsigned short numbers are the same, success case.
        /// </summary>
        [Fact]
        public void UShortMustBeEqualsTest()
        {
            const ushort number1 = 1;
            const ushort number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two unsigned short numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void UShortMustNotBeEqualsThrowsTest()
        {
            const ushort number1 = 1;
            const ushort number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
                
        /// <summary>
        /// Validates if two long numbers are the same, success case.
        /// </summary>
        [Fact]
        public void LongMustNotBeEqualsTest()
        {
            const long number1 = 1;
            const long number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two long numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void LongMustBeEqualsThrowsTest()
        {
            const long number1 = 1;
            const long number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two long numbers are the same, success case.
        /// </summary>
        [Fact]
        public void LongMustBeEqualsTest()
        {
            const long number1 = 1;
            const long number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two long numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void LongMustNotBeEqualsThrowsTest()
        {
            const long number1 = 1;
            const long number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two float numbers are the same, success case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeEqualsTest()
        {
            const float number1 = 0.01F;
            const float number2 = 0.02F;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two float numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void FloatMustBeEqualsThrowsTest()
        {
            const float number1 = 0.01F;
            const float number2 = 0.02F;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two float numbers are the same, success case.
        /// </summary>
        [Fact]
        public void FloatMustBeEqualsTest()
        {
            const float number1 = 0.01F;
            const float number2 = 0.01F;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two float numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeEqualsThrowsTest()
        {
            const float number1 = 0.01F;
            const float number2 = 0.01F;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two decimal numbers are the same, success case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeEqualsTest()
        {
            const decimal number1 = 1;
            const decimal number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two decimal numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustBeEqualsThrowsTest()
        {
            const decimal number1 = 1;
            const decimal number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two decimal numbers are the same, success case.
        /// </summary>
        [Fact]
        public void DecimalMustBeEqualsTest()
        {
            const decimal number1 = 1;
            const decimal number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two decimal numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeEqualsThrowsTest()
        {
            const decimal number1 = 1;
            const decimal number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two double numbers are the same, success case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeEqualsTest()
        {
            const double number1 = 0.01;
            const double number2 = 0.02;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two double numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustBeEqualsThrowsTest()
        {
            const double number1 = 0.01;
            const double number2 = 0.02;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two double numbers are the same, success case.
        /// </summary>
        [Fact]
        public void DoubleMustBeEqualsTest()
        {
            const double number1 = 0.01;
            const double number2 = 0.01;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two double numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeEqualsThrowsTest()
        {
            const double number1 = 0.01;
            const double number2 = 0.01;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two long numbers are the same, success case.
        /// </summary>
        [Fact]
        public void ULongMustNotBeEqualsTest()
        {
            const ulong number1 = 1;
            const ulong number2 = 2;

            var exception = Record.Exception(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two long numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void ULongMustBeEqualsThrowsTest()
        {
            const ulong number1 = 1;
            const ulong number2 = 2;

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two unsigned long numbers are the same, success case.
        /// </summary>
        [Fact]
        public void ULongMustBeEqualsTest()
        {
            const ulong number1 = 1;
            const ulong number2 = 1;

            var exception = Record.Exception(() => Law.MustBeEquals(number1, number2, _defaultMessage));

            Assert.Null(exception);
        }
        
        /// <summary>
        /// Validates if two unsigned long numbers are the same, fail case.
        /// </summary>
        [Fact]
        public void ULongMustNotBeEqualsThrowsTest()
        {
            const ulong number1 = 1;
            const ulong number2 = 1;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEquals(number1, number2, _defaultMessage));
        }
        
        /// <summary>
        /// Validates if two strings are the same, fail case.
        /// </summary>
        [Fact]
        public void StringsMustBeEqualsThrowsTest()
        {
            const string foo = "Foo";
            const string bar = "Bar";

            Assert.Throws<GuiltyException>(() => Law.MustBeEquals(foo, bar, _defaultMessage));
        }

        /// <summary>
        /// Validates if two strings are the same, success case.
        /// </summary>
        [Fact]
        public void StringsMustBeEqualsTest()
        {
            const string foo = "Foo";
            const string bar = "Foo";

            var exception = Record.Exception(() => Law.MustBeEquals(foo, bar, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a string length is lower than defined, fail case.
        /// </summary>
        [Fact]
        public void StringMustBeLowerLengthThrowsTest()
        {
            const string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeLowerLength(foo, 3, _defaultMessage));
        }

        /// <summary>
        /// Validates if a string length is lower than defined, success case.
        /// </summary>
        [Fact]
        public void StringMustBeLowerLengthTest()
        {
            const string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeLowerLength(foo, 10, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a string length is between an interval than defined, fail case.
        /// </summary>
        [Fact]
        public void StringMustBeInBetweensLengthThrowsTest()
        {
            const string foo = "Foobar";

            Assert.Throws<GuiltyException>(() => Law.MustBeInBetweensLength(foo, 3, 5, _defaultMessage));
        }

        /// <summary>
        /// Validate if a string length is between an interval than defined, success case.
        /// </summary>
        [Fact]
        public void StringMustBeInBetweensLengthTest()
        {
            const string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustBeInBetweensLength(foo, 5, 10, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a string is empty, fail case.
        /// </summary>
        [Fact]
        public void StringMustNotBeEmptyThrowsTest()
        {
            var foo = string.Empty;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeEmpty(foo, _defaultMessage));
        }

        /// <summary>
        /// Validates if a string is empty, success case.
        /// </summary>
        [Fact]
        public void StringMustNotBeEmptyTest()
        {
            const string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustNotBeEmpty(foo, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if an object is null, fail case.
        /// </summary>
        [Fact]
        public void ObjectMustNotBeNullThrowsTest()
        {

            Assert.Throws<GuiltyException>(() => Law.MustNotBeNull(null, _defaultMessage));
        }

        /// <summary>
        /// Validates if an object is null, success case.
        /// </summary>
        [Fact]
        public void ObjectMustNotBeNullTest()
        {
            const string foo = "Foobar";

            var exception = Record.Exception(() => Law.MustNotBeNull(foo, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a double number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeInBetweensThrowsTest()
        {
            const double amount = 0.5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0, 2.0, _defaultMessage));
        }

        /// <summary>
        /// Validates if a double number is between an interval, success case.
        /// </summary>
        [Fact]
        public void DoubleMustNotBeInBetweensTest()
        {
            const double amount = 2.25;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0, 2.5, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a float number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeInBetweensThrowsTest()
        {
            const float amount = 0.5f;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0f, 2.0f, _defaultMessage));
        }

        /// <summary>
        /// Validates if a float number is between an interval, success case.
        /// </summary>
        [Fact]
        public void FloatMustNotBeInBetweensTest()
        {
            const float amount = 2.25f;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 2.0f, 2.5f, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void IntMustNotBeInBetweensThrowsTest()
        {
            const int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        /// <summary>
        /// Validates if an int number is between an interval, success case.
        /// </summary>
        [Fact]
        public void IntMustNotBeInBetweensTest()
        {
            const int amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validate if a long number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void LongMustNotBeInBetweensThrowsTest()
        {
            const long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1, 2, _defaultMessage));
        }

        /// <summary>
        /// Validates if a long number is between an interval, success case.
        /// </summary>
        [Fact]
        public void LongMustNotBeInBetweensTest()
        {
            const long amount = 225;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200, 250, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a decimal number is between an interval, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeInBetweensThrowsTest()
        {
            const decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustNotBeInBetweens(amount, 1.0M, 2.0M, _defaultMessage));
        }

        /// <summary>
        /// Validates if a decimal number is between an interval, success case.
        /// </summary>
        [Fact]
        public void DecimalMustNotBeInBetweensTest()
        {
            const decimal amount = 225.0M;

            var exception = Record.Exception(() => Law.MustNotBeInBetweens(amount, 200.0M, 250.0M, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a long number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void LongMustBeHigherThrowsTest()
        {
            const long amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        /// <summary>
        /// Validates if a long number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void LongMustBeHigherTest()
        {
            const long amount = 5;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a double number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void DoubleMustBeHigherThrowsTest()
        {
            const double amount = 5.0;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0, _defaultMessage));
        }

        /// <summary>
        /// Validates if a double number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void DoubleMustBeHigherTest()
        {
            const double amount = 5.0;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a decimal number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void DecimalMustBeHigherThrowsTest()
        {
            const decimal amount = 5.0M;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10.0M, _defaultMessage));
        }

        /// <summary>
        /// Validates if a decimal number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void DecimalMustBeHigherTest()
        {
            const decimal amount = 5.0M;

            var exception = Record.Exception(() => Law.MustBeHigher(amount, 2.0M, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is higher that a number defined, fail case.
        /// </summary>
        [Fact]
        public void IntMustBeHigherThrowsTest()
        {
            const int amount = 5;

            Assert.Throws<GuiltyException>(() => Law.MustBeHigher(amount, 10, _defaultMessage));
        }

        /// <summary>
        /// Validates if an int number is higher that a number defined, success case.
        /// </summary>
        [Fact]
        public void IntMustBeHigherTest()
        {
            const int amount = 5;

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
        /// Validates if a boolean expression is true, success case.
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
            var options = new[]
            {
                "hello",
                "world"
            };

            Assert.Throws<GuiltyException>(() => Law.MustBeContained("foo", options, _defaultMessage));
        }

        /// <summary>
        /// Validates if a string value is contained on a list, success case.
        /// </summary>
        [Fact]
        public void StringMustBeContainedTest()
        {
            var options = new[]
            {
                "hello",
                "world"
        };

            var exception = Record.Exception(() => Law.MustBeContained("hello", options, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if a string value is not contained on a list, fail case.
        /// </summary>
        [Fact]
        public void StringMustNotBeContainedThrowsTest()
        {
            var options = new[]
            {
                "hello",
                "world"
            };

            Assert.Throws<GuiltyException>(() => Law.MustNotBeContained("hello", options, _defaultMessage));
        }

        /// <summary>
        /// Validates if a string value is not contained on a list, success case.
        /// </summary>
        [Fact]
        public void StringMustNotBeContainedTest()
        {
            var options = new[]
            {
                "hello",
                "world"
        };

            var exception = Record.Exception(() => Law.MustNotBeContained("foo", options, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is contained on a list, fail case.
        /// </summary>
        [Fact]
        public void IntMustBeContainedThrowsTest()
        {
            var options = new[]
            {
                2,
                4
            };

            Assert.Throws<GuiltyException>(() => Law.MustBeContained(1, options, _defaultMessage));
        }

        /// <summary>
        /// Validates if an int number is contained on a list, success case.
        /// </summary>
        [Fact]
        public void IntMustBeContainedTest()
        {
            var options = new[]
            {
                2,
                4
            };

            var exception = Record.Exception(() => Law.MustBeContained(4, options, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is not contained on a list, success case.
        /// </summary>
        [Fact]
        public void IntMustNotBeContainedThrowsTest()
        {
            var options = new[]
            {
                2,
                4
            };

            var exception = Record.Exception(() => Law.MustNotBeContained(4, options, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is not contained on a list, fail case.
        /// </summary>
        [Fact]
        public void IntMustNotBeContainedTest()
        {
            var options = new[]
            {
                2,
                4
            };

            Assert.Throws<GuiltyException>(() => Law.MustNotBeContained(1, options, _defaultMessage));
        }


        /// <summary>
        /// Validates if an int number is lower than a value, success case.
        /// </summary>
        [Fact]
        public void IntMustBeLowerTest()
        {

            Assert.Throws<GuiltyException>(() => Law.MustBeLower(12, 10, _defaultMessage));
        }

        /// <summary>
        /// Validates if an int number is lower than a value, fail case.
        /// </summary>
        [Fact]
        public void IntMustBeLowerThrowsTest()
        {
            var exception = Record.Exception(() => Law.MustBeLower(10, 12, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is not lower than a value, success case.
        /// </summary>
        [Fact]
        public void IntMustNotBeLowerTest()
        {
            var exception = Record.Exception(() => Law.MustNotBeLower(12, 10, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an int number is not lower than a value, fail case.
        /// </summary>
        [Fact]
        public void IntMustNotBeLowerThrowsTest()
        {
            Assert.Throws<GuiltyException>(() => Law.MustNotBeLower(10, 12, _defaultMessage));
        }

        /// <summary>
        /// Validates if an string is alphanumeric, success case.
        /// </summary>
        [Theory]
        [InlineData("")]
        [InlineData("a12324ffd")]
        [InlineData("hello world")]
        [InlineData("_--|||||")]
        public void StringMustBeAlphaNumericTest(string value)
        {
            var exception = Record.Exception(() => Law.MustBeAlphanumeric(value, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an string is alphanumeric, fail case.
        /// </summary>
        [Theory]
        [InlineData("123245")]
        [InlineData("000000")]
        public void StringMustBeAlphaNumericThrowsTest(string value)
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeAlphanumeric(value, _defaultMessage));
        }

        /// <summary>
        /// Validates if an string is numeric, success case.
        /// </summary>
        [Theory]
        [InlineData("123245")]
        [InlineData("000000")]
        public void StringMustBeNumericTest(string value)
        {
            var exception = Record.Exception(() => Law.MustBeNumeric(value, _defaultMessage));

            Assert.Null(exception);
        }

        /// <summary>
        /// Validates if an string is numeric, fail case.
        /// </summary>
        [Theory]
        [InlineData("")]
        [InlineData("a12324ffd")]
        [InlineData("hello world")]
        [InlineData("_--|||||")]
        public void StringMustBeNumericThrowsTest(string value)
        {
            Assert.Throws<GuiltyException>(() => Law.MustBeNumeric(value, _defaultMessage));
        }
    }
}