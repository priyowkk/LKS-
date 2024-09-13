using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car ("porsche");
            Console.WriteLine(car.Model );
            Console.ReadKey();
        }
    }
}
class Car
{

    public String Model { get; set; }

    public Car(String model)
    {
        this.Model = model;
    }
}


