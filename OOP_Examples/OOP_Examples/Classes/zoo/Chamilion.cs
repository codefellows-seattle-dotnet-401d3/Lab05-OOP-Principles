using System;

namespace OOP_Examples.Classes.zoo
{
    class Chamilion : Lizard
    {
        new string Food { get; set; } = "small prey";
        public Size LizardSize { get; set; } = Size.tiny;
        new int Cute { get; set; } = 5;
        string speak = "nothing";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a chamilion.  I eat {Food}.  I'm {LizardSize} and I say {speak}."); ;
        }

        public override void Bury()
        {
            Console.WriteLine("Get a cigar box.");
        }

    }

}