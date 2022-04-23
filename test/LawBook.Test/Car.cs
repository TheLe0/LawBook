using System;
using LawBook;

namespace LawBook.Test
{
    public class Car : ILawable
    {
        public string FuelType { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }

        public Car(string fuel, int wheels, int doors)
        {
            FuelType = fuel;
            Wheels = wheels;
            Doors = doors;
        }
        

        public void Validate()
        {
            Law.MustBeContained(FuelType, new string[] { "Gasoline", "Biodiesel" }, "Invalid Fuel Type");
            Law.MustBeEquals(Wheels, 4, "Invalid Number of Wheels");
            Law.MustBeContained(Doors, new int[] { 2, 4}, "Invalid Number of Doors");
        }
    }
}
