using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 1000000; //limited
            Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }
}
class Car
{
    private int speed;

    public Car (int speed)
    {
        Speed = speed;
    }
    public int Speed
    {
        get { return speed; }
        set
        {
            if (value >500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
            speed = value;
        }
    }
}