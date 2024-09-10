using System;

class Program
{
    static void Main()  
    {
        double temp = 20;
        string message;

        message = (temp >= 15) ? "it's warm outside!" : "it's cold outside!";
        Console.WriteLine((temp >= 15 ) ? "it's warm outside!" : "it's cold outside!");

        Console.ReadKey();
    }
}