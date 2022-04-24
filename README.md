# LawBook
[![NuGet Version](https://img.shields.io/nuget/v/LawBook.svg)](https://www.nuget.org/packages/LawBook/ "NuGet Version")
[![NuGet Downloads](https://img.shields.io/nuget/dt/LawBook.svg)](https://www.nuget.org/packages/LawBook/ "NuGet Downloads")
[![Build](https://github.com/TheLe0/LawBook/actions/workflows/deploy_nuget.yml/badge.svg)](https://github.com/TheLe0/LawBook/actions/workflows/deploy_nuget.yml) 
[![Build](https://github.com/TheLe0/LawBook/actions/workflows/pull_request.yml/badge.svg)](https://github.com/TheLe0/LawBook/actions/workflows/pull_request.yml)

![LawBook](./images/logo.png)

LawBook provide some classes that helps you to do validations on your own classes. You can validate a lot of things, if values match or not, is on a specified interval, is contained on a list of values, match to a regex expression and a lot of other things.

This project was made because in a lot of projects I had to reproduce this validations structures, so I came with the idea to create a package with this solution and share with people who might find this helpfull.

The name of the solution, classes and methods came with an analogy to the law principles, where is specified your rights, rules and obligations to live in a society. So, in a software conception, the objects must follow too the rights, rules and obligations to make a software as expected.

## How to use ###

You can run the validations in two ways:

* Calling in code explicitly each of the validations;
* Encapsule all the validations in a method and call by an Executor.


The first way is calling it explicitly, just call the method of the validation needed whever
you want:

```csharp
Law.MustBeTrue(1 > 2, "1 is not higher than 2!");
```
So, when you call this expression is going to throw an GuiltyException, because the validation failed.

And the other is encapsuling the validations in a method and call than with an executor, this way the validations are going to be centralized and you can call at the moment you want and multiple times.

```csharp
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
```

For example, this class Car, was created the method Validate, inherited by the interface ILawable flaging that this class is validatable. And on the method you can see all the validations that an object of the type Car must follow.

And after to trigger the validations you can do this by two ways:

The simple one, like all methods are called:

```csharp
myCar.Validate();
```

And using an executor:

```csharp
Judge.Sentence(myCar, false);
```

But, why using an executor to run the method? You can do this just calling the ``` Validate() ```.
This is because, with the Executor we can pass configurations and manage how the validations are going to be executed. 

This project is young, and the executor currently only have a flag to silence or not the thrown of the exception. Have a lot more planned to grow and make this more suitable and strong solution.
