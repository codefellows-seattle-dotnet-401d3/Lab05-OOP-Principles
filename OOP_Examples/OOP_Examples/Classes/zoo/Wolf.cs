using System;

namespace OOP_Examples.Classes.zoo
{
    class Wolf : Canine
    {
        new int Cute { get; set; } = 4;
        new int Noble { get; set; } = 7;

        string speak = "hoooooooooooooolw!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a wolf.  I eat {Food}.  I'm {CanineSize} and I say {speak}."); ;
        }

        public override void CleanUp()
        {
            Console.WriteLine("Keep it outside of the den.");
        }

        public override void Bury()
        {
            Console.WriteLine(speak);
        }
    }
}
