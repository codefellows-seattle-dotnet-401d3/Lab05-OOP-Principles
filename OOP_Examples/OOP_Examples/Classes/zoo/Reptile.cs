using System;

namespace OOP_Examples.Classes.zoo
{
    abstract class Reptile : Animals
    {
        public Sleep ReptileSleep { get; set; } = Sleep.day;
        public Size ReptileSize { get; set; } = Size.small;
        new int Cute = 2; // I get green underline warnings that these are assigned, but not used.  The only way to pass baseline variables seems to be this way.
        new int Noble = 2;

        public override void CleanUp()
        {
            Console.WriteLine("I think I'll shed my skin");
        }


    }

}