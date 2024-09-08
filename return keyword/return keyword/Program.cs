using System;

class Program
{
    static void Main()
    {
        double x;
        double y;
        double hasil;
        Console.WriteLine("enter in num 1: ");   
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter in num 2: ");
        y = Convert.ToDouble(Console.ReadLine());
        
        hasil = Multiply(x, y) ;

        Console.WriteLine(hasil);

        Console.ReadKey();
    }
    static double Multiply(double x,double y)
    {
        
        return x * y;
    }
    
}