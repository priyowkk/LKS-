using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        car car1 = new car("Toyota", "Avaza", 2022, "red");
        car car2 = new car("Toyota", "Raize", 2020, "yellow");

        car1.Drive();
        car2.Drive();
        Console.ReadKey();
    }
}
class car
{
    String make;
    String model;
    int year;
    String color;

    public car(String make, String model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }
    public void Drive()
    {
        Console.WriteLine("u drive the " + make + " " + model);
    }
}
