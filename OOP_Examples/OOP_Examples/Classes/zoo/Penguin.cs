using System;

namespace OOP_Examples.Classes.zoo
{
    class Penguin : Flighless
    {
        new string Food { get; set; } = "fish";
        public Sleep PenguinSleep { get; set; } = Sleep.diurnal;
        public Size PenguinSize { get; set; } = Size.small;
        new int Cute { get; set; } = 10;
        new int Noble { get; set; } = 9;

        string speak = "screech!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a penguin.  I eat {Food}.  I'm {PenguinSize} and I say {speak}."); ;
        }

    }

}
