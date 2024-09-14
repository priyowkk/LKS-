using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            //Thread thread1 = new Thread(CD);
            //Thread thread2 = new Thread(CU);

            //thread1.Start();
            //thread2.Start();      //ini kalau ingin menghitung bersamaan

            CD();
            CU();

            Console.WriteLine(mainThread.Name + "is complete!");


            Console.ReadKey();
        }

        public static void CD()
        {
            for(int i = 10; i>=0;i--) 
            {
                Console.WriteLine("timer #1 :" + i + "scnds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #1 is complete");
        }
        public static void CU()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("timer #2 :" + i + "scnds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #2 is complete");
        }
    }
}