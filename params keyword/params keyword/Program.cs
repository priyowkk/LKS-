using System;

class Program
{
    static void Main()
    {
        double total = CheckOut(3.99, 5.75, 15);
        Console.WriteLine(total);
        Console.ReadKey();

    }
    static double CheckOut(params double[] prices)
    {
        double total = 0;
        foreach(double price in prices)
        {
            total += price;
        }
        return total;
    }

}