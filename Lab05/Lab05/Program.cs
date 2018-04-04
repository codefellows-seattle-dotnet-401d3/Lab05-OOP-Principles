using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon testDragon = new Dragon();

            Console.WriteLine(testDragon.Name);
            Console.WriteLine(testDragon.Feed(10,5));
            Console.WriteLine(testDragon.ThreatLevel(6));
            Console.WriteLine(testDragon.NativePlane);
            Console.ReadLine();
        }
    }
}
