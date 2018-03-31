using System;

namespace OOP_Examples.Classes.zoo
{
	class Rabbit : Langomorph
	{
        new string Food { get; set; } = "vegitarian";
        public Sleep RabbitSleep { get; set; } = Sleep.diurnal;
        public Size RabbitSize { get; set; } = Size.small;
        public override int Cute { get; set; } = 10; // Override Langomorph baseline
        public override int Noble { get; set; } = 2;

        string speak = "nothing, or scream!!";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a rabbit.  I eat {Food}.  I'm {RabbitSize} and I say {speak}."); ;
        }

        public override void CleanUp()
        {
            Console.WriteLine("Pellets are edible!");
        }

        public override void Bury()
        {
            Console.WriteLine("Easy come, easy go.");
        }
    }
}
