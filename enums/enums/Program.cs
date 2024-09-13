using System;

namespace LKS
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Radius.jupiter.ToString();
            int radius = (int)Radius.jupiter;
            double volume = Volume(Radius.jupiter);

            Console.WriteLine("planet : "+ name);
            Console.WriteLine("radius :" + radius );
            Console.WriteLine("volume :") + volume + "km^3");


            Console.ReadKey();
        }
        public static void Volume(Radius radius )
        {
            double volume = (4.0 / 3.0 )* Math.Pow((int)radius, 2);
        }
    }

}
enum Planets
{
    merkurius = 1,
    venus = 2,
    bumi = 3,
    mars = 4,
    jupiter = 5,
    saturnus = 6,
    uranus = 7,
    neptunus = 8,
    pluto = 9
}
enum Radius
{
    merkurius = 12,
    venus = 22,
    bumi = 32,
    mars = 42,
    jupiter = 52,
    saturnus = 62,
    uranus = 72,
    neptunus = 82,
    pluto = 92

}
