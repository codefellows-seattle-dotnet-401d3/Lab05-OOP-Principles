using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    class Charmander : Firetype
    {
        public override string Attack { get; set; } = "Flame Spit";
        public override string Name { get; set; } = "Charmander";
        public override int Health { get; set; } = 100;
    }
}
