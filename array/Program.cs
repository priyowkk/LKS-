using System;

class Program
{
    static void Main()
    {
        string[] cars = new string[3];

        cars[0] = "vario";
        cars[1] = "supra";
        cars[2] = "nmax";

        for (int i = 0;i < cars.Length;i++)
        {
            Console.WriteLine(cars[i]);

        }
        Console.ReadKey();

    }
}
