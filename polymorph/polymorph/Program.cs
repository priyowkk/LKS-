using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bike, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }
}

class Vehicle
{
    public virtual void Go()
    {

    }
}
 class Car : Vehicle
 { 
    public override void Go()
    {
        Console.WriteLine("the car is moving");
    }
 }
class Bike : Vehicle   
{
    public override  void Go()
    {
        Console.WriteLine("the bike is moving");
    }
}
class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("the boat is moving");
    }
}