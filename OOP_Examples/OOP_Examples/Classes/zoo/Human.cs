using System;

namespace OOP_Examples.Classes.zoo
{
	class Human : Primate
	{
        new string Food { get; set; } = "everything";
        public Sleep HumanSleep { get; set; } = Sleep.night;
        public Size HumanSize { get; set; } = Size.medium;
        new int Cute { get; set; } = 4;
        new int Noble { get; set; } = 7;

        string speak = "Help! Get me outta here!!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a human.  I eat {Food}.  I'm {HumanSize} and I say {speak}."); ;
        }

        public override void CleanUp()
        {
            Console.WriteLine("Go to the bathroom"); 
        }

        public override void Bury()
        {
            Console.WriteLine("Go to the funeral home");
        }
    }

}
