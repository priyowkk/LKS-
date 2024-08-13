using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is ur name?");
             string name =Console.ReadLine();

            Console.WriteLine("hwo old u is?");
            int age = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("What is ur insta name?");
           // char insta = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("ur name is " + name);
            Console.WriteLine("u are " + age +"years old");
            //Console.WriteLine("ur insta name is " +'@'+ insta);
        }
    }
}
