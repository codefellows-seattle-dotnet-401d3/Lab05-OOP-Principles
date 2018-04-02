using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    abstract class Watertype : Pokemon
    {
        //Properties for water type Pokemon
        public override string Weakness { get; set; } = "Plants";
        

        //methods for water type Pokemon
        public virtual string BubbleAttack()
        {
            return "Shoots bubbles";
        }

        public virtual string Tackle()
        {
            return "Tackle Atack Go!";
        }

    }
}
