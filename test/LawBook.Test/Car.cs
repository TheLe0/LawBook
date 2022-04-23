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

namespace LawBook.Test
{
    /// <summary>
    /// Class <c>Car</c> used as an arbitrary object to make some tests.
    /// </summary>
    /// <seealso cref="LawBook.ILawable" />
    public class Car : ILawable
    {
        public string FuelType { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="fuel">Type of the fuel.</param>
        /// <param name="wheels">Number of wheels.</param>
        /// <param name="doors">Number of doors.</param>
        public Car(string fuel, int wheels, int doors)
        {
            FuelType = fuel;
            Wheels = wheels;
            Doors = doors;
        }

        /// <inheritdoc />
        /// <exception cref="GuiltyException" />
        public void Validate()
        {
            Law.MustBeContained(FuelType, new string[] { "Gasoline", "Biodiesel" }, "Invalid Fuel Type");
            Law.MustBeEquals(Wheels, 4, "Invalid Number of Wheels");
            Law.MustBeContained(Doors, new int[] { 2, 4}, "Invalid Number of Doors");
        }
    }
}
