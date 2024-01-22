using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 23;

        var cars = new List<Car>();

        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        owner.name = "bob";
        owner.phone = "333-333-3333";
        car.owner = owner;


        cars.Add(car);

        car = new Car();
        car.make = "Ford";
        car.model = "F- 150";
        car.year = 2023;
        car.gallons = 30;
        car.milesPerGallon = 5;

        owner = new Person();
        owner.name = "Sue";
        owner.phone = "444-444-4444";
        car.owner = owner;

        cars.Add(car);

        Console.Clear();
        foreach (var c in cars)
        {
            // System.Console.WriteLine($"{c.make} {c.model}: totalRange = {c.TotalRange()}");
            c.Display();
        }
    }
}
