using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3};
            double[] doubleArray = {1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2,", "3"};

            DisplayE(intArray);
            DisplayE(doubleArray);
            DisplayE(stringArray);
            Console.ReadKey();
        }

        //atau bisa menggunakan <Thing> sebagai argumen
        public static void DisplayE(int[]array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void DisplayE(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void DisplayE(String[] array)
        {
            foreach (String item in array)
            {
                Console.Write(item + " ");
            }
              
        }
    }

}