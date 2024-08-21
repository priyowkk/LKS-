using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_8_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ts = '!';
            Console.WriteLine("Berapa suhu di Sidoarjo skarang?");
            double suhu = Convert.ToDouble(Console.ReadLine());

            if (suhu >= 5 && suhu <= 45)
            {
                Console.WriteLine("oke itu normal");
            }
            else if (suhu <= -1 || suhu >= 46) ;
            {
                Console.WriteLine("ITU BADAI!!");
            }

           // else if (suhu <-)
            Console.ReadKey();
        }
    }
}
