using System;

namespace OOP_Examples.Classes.zoo
{
    class Dog : Canine
    {
        new int Cute { get; set; } = 5;
        new int Noble { get; set; } = 6;

        string speak = "bark!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a dog.  I eat {Food}.  I'm {CanineSize} and I say {speak}."); ;
        }

        public override void CleanUp()
        {
            Console.WriteLine("fire hydrant.");
        }

        public override void Bury()
        {
            Console.WriteLine("Hooooooooooooww!");
        }
    }
}
