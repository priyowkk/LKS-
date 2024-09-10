using System;

class Program
{
    static void Main()
    {
        Console.Write("Nama Depan :");
        string FN = Console.ReadLine();

        Console.Write("Nama Belakang :");
        string LN = Console.ReadLine();

        Console.Write("usia :");
        int age = Convert.ToInt32(Console.ReadLine());

        

        //Console.WriteLine("hello" + FN + " " + LN);
        //Console.WriteLine("you are " + age  + "years old");

        Console.WriteLine($"hello {FN} {LN}.");
        Console.WriteLine($"you are {age} years old");
    }
}