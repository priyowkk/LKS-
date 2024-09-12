using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = new Car[3] ;

            Car car1 = new Car("avanza");
            Car car2 = new Car("Lambo");
            Car car3 = new Car("yaris");

            garage[0] = car1;
            garage [1] = car2;
            garage[2] = car3;

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }



            Console.ReadKey();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }

    }
}
