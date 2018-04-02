using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    class Charizoid :Firetype
    {
        public override string Attack { get; set; } = "Flame Thrower";
        public override string Name { get; set; } = "Charizoid";
        public override int Health { get; set; } = 500;

        public override string CanEvolve()
        {
            Console.WriteLine("Charizoid is already Evolved");
            return "Evolved";
        }
    }
}
