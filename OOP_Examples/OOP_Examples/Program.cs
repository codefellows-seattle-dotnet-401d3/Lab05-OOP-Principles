using OOP_Examples.Classes;
using System;

namespace OOP_Examples.Classes.zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ape ape = new Ape();
            Human human = new Human();
            Rabbit rabbit = new Rabbit();
            BaldEagle baldEagle = new BaldEagle();
            Penguin penguin = new Penguin();
            Chamilion chamilion = new Chamilion();
            Wolf wolf = new Wolf();

            Console.WriteLine("The ape says:");
            ape.Speak();
            Console.WriteLine("And when it is time to clean up you need to:");
            ape.CleanUp();
            Console.WriteLine("The human says:");
            human.Speak();
            Console.WriteLine("And when it is time to bury him you need to:");
            human.Bury();
            Console.WriteLine("The rabbit says:");
            rabbit.Speak();
            Console.WriteLine($"And her cuteness rating is {rabbit.Cute}.");
            Console.WriteLine("The bald eagle says:");
            baldEagle.Speak();
            Console.WriteLine($"And his nobility rating is {baldEagle.Noble}");  
            Console.WriteLine("The penguin says:");
            penguin.Speak();
            Console.WriteLine("And her sleep pattern is:");
            Console.WriteLine(penguin.PenguinSleep);
            Console.WriteLine("The chammilion says:");
            chamilion.Speak();
            Console.WriteLine("And when it's time to clean up he says:");
            chamilion.CleanUp();
            Console.WriteLine("The wolf says:");
            wolf.Speak();
            Console.WriteLine("And when somebody dies he says:");
            wolf.Bury();
            
        }
    }
}
