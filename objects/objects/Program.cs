using System;

class Program
{
    static void Main()
    {
        human human1 = new human();

        human1.name = "Angga";
        human1.age = 15;
        human1.eat();
        human1.sleep();
        Console.ReadKey();
    }

}

class human
{
    public String name;
    public int age;

    public void eat ()
    {
        Console.WriteLine(name + " is eating");
    }
    public void sleep ()
    {
        Console.WriteLine(name + " is sleeping");
    }
}