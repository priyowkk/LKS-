using System;

namespace Inheritace
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Cycle cycle = new Cycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(cycle.speed);
            Console.WriteLine(cycle.wheels);
            cycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();


            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This Vehicle Is Moving!!");
        }
    }
    class Car:Vehicle
    {
        public int wheels = 4;
    }
    class Cycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}