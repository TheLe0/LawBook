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

using System.Text.RegularExpressions;

namespace LawBook
{
    /// <summary>
    /// Class <c>Law</c> is where all the validations are made.
    /// </summary>
    public class Law
    {

        /// <summary>
        /// Validate if two <c>objects</c> are distinct to each other.
        /// </summary>
        /// <param name="object1">An object to compare.</param>
        /// <param name="object2">An object to be compared.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">object1</exception>
        public static void MustNotBeEquals(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if two <c>objects</c> are the same.
        /// </summary>
        /// <param name="object1">An object to compare.</param>
        /// <param name="object2">An object to be compared.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">object1</exception>
        public static void MustBeEquals(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if two <c>objects</c> are the same.
        /// </summary>
        /// <param name="regexExp">An regular expression to match.</param>
        /// <param name="value">The string value to be compared.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeEquals(string regexExp, string value, string message)
        {
            var regex = new Regex(regexExp);

            if (!regex.IsMatch(value))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a string length is lower than the value defined.
        /// </summary>
        /// <param name="value">The string value to be compared.</param>
        /// <param name="max">The maximum length allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeLowerLength(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a string length is between a defined interval.
        /// </summary>
        /// <param name="value">The string value to be compared.</param>
        /// <param name="min">The minimun length allowed.</param>
        /// <param name="max">The maximum length allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeInBetweensLength(string value, int min, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < min || length > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a string is not empty.
        /// </summary>
        /// <param name="value">The string value to be compared.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0 || value == string.Empty)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if an object is not null.
        /// </summary>
        /// <param name="object1">The object to be compared.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">object1</exception>
        public static void MustNotBeNull(object? object1, string message)
        {
            if (object1 == null)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type double is outside an interval.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="max">The maximum value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeInBetweens(double value, double min, double max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type float is outside an interval.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="max">The maximum value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeInBetweens(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type int is outside an interval.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="max">The maximum value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeInBetweens(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type long is outside an interval.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="max">The maximum value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeInBetweens(long value, long min, long max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type decimal is outside an interval.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="max">The maximum value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeInBetweens(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type long is higher than a defined value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeHigher(long value, long min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type double is higher than a defined value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeHigher(double value, double min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type decimal is higher than a defined value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeHigher(decimal value, decimal min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type int is higher than a defined value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="min">The minimun value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeHigher(int value, int min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a value is the boolean true value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeTrue(bool value, string message)
        {
            if (!value)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a value is the boolean false value.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeFalse(bool value, string message)
        {
            if (value)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a string value is contained on a list.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="options">The list of values allowed.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeContained(string value, string[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a string value is not contained on a list.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="options">The list of values allowed.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeContained(string value, string[] options, string message)
        {
            if (options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type int is contained on a list.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="options">The list of values allowed.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeContained(int value, int[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a number of type int is not contained on a list.
        /// </summary>
        /// <param name="value">The value to be compared.</param>
        /// <param name="options">The list of values allowed.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeContained(int value, int[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a int value is lower than the specified value.
        /// </summary>
        /// <param name="value">The int value to be compared.</param>
        /// <param name="max">The limit value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustBeLower(int value, int max, string message)
        {
            if (value >= max)
            {
                throw new GuiltyException(message);
            }
        }

        /// <summary>
        /// Validate if a int value is not lower than the specified value.
        /// </summary>
        /// <param name="value">The int value to be compared.</param>
        /// <param name="max">The limit value allowed.</param>
        /// <param name="message">Message that shows If the exception throws.</param>
        /// <exception cref="GuiltyException">value</exception>
        public static void MustNotBeLower(int value, int max, string message)
        {
            if (value < max)
            {
                throw new GuiltyException(message);
            }
        }
    }
}
