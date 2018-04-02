using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    abstract class Firetype : Pokemon
    {
        //Firetype properties
        public override string Weakness { get; set; } = "This pokemon weakness is Water";

        //Firetype methods
        public virtual string EmberAttack()
        {
            Console.WriteLine("This pokemon Embers at the fire");
            return "Embers";
        }

        public virtual string Flying()
        {
            Console.WriteLine("This Pokemon is Flying");
            return "Spread Wings and Flys";
        }
    }
}
