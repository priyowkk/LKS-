using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
            Console.ReadKey();
        }
    }
}
 class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("the animal goes brrrr");
    }
}        
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("the doh goes wooff");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("the cat goes miawwww");
    }
}