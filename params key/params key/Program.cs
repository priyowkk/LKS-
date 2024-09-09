using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        double total = CO(3.99, 5.75, 15, 1.00, 10.25);
        Console.WriteLine(total);
        Console.ReadKey();

    }
    static double CO(params double[] prices )
    {
        double total = 0;

        foreach( double price in prices )
        {
            total += price;
        }
        return total;
    } 
}