using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    abstract class Firetype : Pokemon
    {
        //Firetype properties
        public override string Weakness { get; set; } = "Water";

        //Firetype methods
        public virtual string EmberAttack()
        {
            return "Embers";
        }

        public virtual string Flying()
        {
            return "Spread Wings and Flys";
        }
    }
}
