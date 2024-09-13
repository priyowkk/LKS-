using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food  = new List<string>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");


            //food.Remove("fries");

            foreach (string item  in food)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}