using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    class Charmander : Firetype
    {
        public override string Attack { get; set; } = "Attacks with Flame Spit";
        public override string Name { get; set; } = "Charmander";
        public override int Health { get; set; } = 100;

        public override string Flying()
        {
            Console.WriteLine("Charmander Cannot Fly");
            return "Charmander Cannot fly";
        }
    }
}
