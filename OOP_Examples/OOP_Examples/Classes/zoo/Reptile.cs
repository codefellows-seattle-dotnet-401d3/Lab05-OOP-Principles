using System;

namespace OOP_Examples.Classes.zoo
{
    abstract class Reptile : Animals
    {
        public Sleep ReptileSleep { get; set; } = Sleep.night;
        public Size ReptileSize { get; set; } = Size.small;
        new int Cute = 2; // Sets baselines
        new int Noble = 2;

        public override void CleanUp()
        {
            Console.WriteLine("I think I'll shed my skin");
        }


    }

}