using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    abstract class Pokemon
    {
        //properties of all the pokemon
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract string Attack { get; set;}
        public abstract string Weakness { get; set; }

        //methods for all pokemon
        public virtual string CanEvolve()
        {
            Console.WriteLine("This Pokemon need to level up");
            return "this pokemon not yet leveled up";
        }

        public virtual string Catchable()
        {
            Console.WriteLine("This Pokemon needs to be caught!");
            return "this pokemon has been caught";
        }

    }
}
