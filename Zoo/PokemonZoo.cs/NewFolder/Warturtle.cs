using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    class Warturtle : Watertype
    {
        public override string Attack { get; set; } = "Water Cannon";
        public override string Name { get; set; } = "Warturtle";
        public override int Health { get; set; } = 100;

        public override string BubbleAttack()
        {
            Console.WriteLine("Shooting Water bubbles");
            return "Shoots water!!!";
        }

    }
}
