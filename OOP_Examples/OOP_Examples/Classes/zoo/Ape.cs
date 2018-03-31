using System;

namespace OOP_Examples.Classes.zoo
{
    class Ape : Primate
    {
        new string Food { get; set; } = "vegetarian";
        public Sleep ApeSleep { get; set; } = Sleep.diurnal; 
        public Size ApeSize { get; set; } = Size.big; 
        new int Cute { get; set; } = 2;
        new int Noble { get; set; } = 7;

        string speak = "Oo oo oo oo oo";


        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm an ape.  I eat {Food} food.  I'm {ApeSize} and I say {speak}.");
        }

        public override void CleanUp()
        {
            Console.WriteLine("Grab a broom");
        }

        public override void Bury()
        {
            throw new NotImplementedException("dead");
        }
    }
}
