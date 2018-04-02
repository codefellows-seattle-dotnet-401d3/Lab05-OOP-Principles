using BuildAZoo.Classes;
using System;

namespace BuildAZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Eagle eagle = new Eagle();
            Console.WriteLine("The eagle object");
            Console.WriteLine("Eagles say: ");
            Console.WriteLine(eagle.Caws());
            Console.WriteLine("Eagles can fly.....");
            Console.WriteLine(eagle.CanFly());
            Console.WriteLine();
            Console.WriteLine();
            Lion leon = new Lion();
            Console.WriteLine("Lion object");
            Console.WriteLine("Lions can roar....");
            Console.WriteLine(leon.Roars());
            Console.WriteLine("Lions have this many cubs: ");
            Console.WriteLine(leon.HaveBabies());
            Console.WriteLine("The lions fur color is: ");
            Console.WriteLine(leon.FurColor);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
