using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();

            hawk.Hunt();

            Fish fish = new Fish();
            fish.Hunt();
            fish = new Fish();
            fish.Flee();

            Console.ReadKey();
        }
    }
}
interface IPrey
{
    void Flee();
}
interface IPredator
{
    void Hunt ();
}
class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("the rabbit runs away!");
    }
}
class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("the hawk is searching for food");
    }
}
class Fish : IPrey, IPredator
{
    public void  Flee()
    {
        Console.WriteLine("the fish is run away!");
    }
    public void Hunt()
    {
        Console.WriteLine("the fish is searching for smaller fish");
    }
}