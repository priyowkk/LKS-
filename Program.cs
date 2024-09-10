using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("INI KALKULATOR!!");

        while (true)
        {
            Console.Write("Masukkan angka pertama: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Yang bener kalo masukin.ini kalkulator");
                continue;
            }

            Console.Write("(+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Yang bener kalo masukin.ini kalkulator");
                continue;
            }

            double hasil;
            bool validOperation = true;

            switch (op)
            {
                case '+':
                    hasil = num1 + num2;
                    break;
                case '-':
                    hasil = num1 - num2;
                    break;
                case '*':
                    hasil = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Tidak Ada Yang Bisa Dibagi 0!");
                        validOperation = false;
                        hasil = 0; 
                    }
                    else
                    {
                        hasil = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Yang bener kalo masukin.ini kalkulator");
                    validOperation = false;
                    hasil = 0; 
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Hasil Dari {num1} {op} {num2} = {hasil}");
            }

            Console.Write("Mau Ngittung Lagi? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Okehhh Makasi");

        Console.ReadKey();


    }
}
