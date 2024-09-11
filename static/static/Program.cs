using System;

class Program
{
    static void Main()
    {
        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Avanza");

        Console.WriteLine(Car.numberOfCars);
        Car.StartRace();



        Console.ReadKey();
    }
}
class Car
{
    String model;
    public static int numberOfCars;

    public Car(String model)
    {
        this.model = model;
        numberOfCars ++;
    }
    public static void StartRace()
    {
        Console.WriteLine("the race has begun!!");
    }
}