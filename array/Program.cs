using System;

class Program
{
    static void Main()
    {
        string[] cars = new string[3];

        cars[0] = "kontol";
        cars[1] = "asu";
        cars[2] = "memek";

        for (int i = 0;i < cars.Length;i++)
        {
            Console.WriteLine(cars[i]);

        }
        Console.ReadKey();

    }
}