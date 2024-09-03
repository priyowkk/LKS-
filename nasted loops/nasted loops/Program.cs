using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasted_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many Rows?:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How Many Columns?:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What Symbol?:");
            string symbol = Console.ReadLine();

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
