using System;

namespace OOP_Examples.Classes.zoo
{
    class BaldEagle : Prey
    {
        new string Food { get; set; } = "other birds";
        public Sleep EagleSleep { get; set; } = Sleep.day;
        public Size EagleSize { get; set; } = Size.medium;
        new public int Cute { get; set; } = 3;
        new public int Noble { get; set; } = 10;

        string speak = "screech!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a bald eagle.  I eat {Food}.  I'm {EagleSize} and I say {speak}."); ;
        }

    }

}