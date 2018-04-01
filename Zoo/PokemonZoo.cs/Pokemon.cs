using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    public abstract class Pokemon
    {
        //properties of all the pokemon
        public abstract string Name { get; set; }
        protected abstract int Health { get; set; }
        protected abstract string Attack { get; set;}
        public abstract string Weakness { get; set; }

        //methods for all pokemon
        public virtual string CanEvolve()
        {
            return "this pokemon not yet leveled up";
        }

        public virtual string Catchable()
        {
            return "this pokemon has been caught";
        }

    }
}
