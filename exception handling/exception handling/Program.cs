using System;

class Program
{
    static void Main()
    {
        int x;
        int y;
        double hasil;
        try
        {
            Console.Write("enter number 1: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter number 2: ");
            y = Convert.ToInt32(Console.ReadLine());

            hasil = x / y;

            Console.WriteLine("hasil :" + hasil);
        }
        catch (FormatException e)
        {
            Console.WriteLine("enter only numbers plase!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("u can't divide by zero IDIOT!!");
        }

        catch (Exception e) 
        {
            Console.WriteLine("Something Gone Wrong!!");
        }
        Console.ReadKey();
    }
}