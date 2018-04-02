using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs.NewFolder
{
    class Bulbasuar : Planttype
    {
        //bulbasusar is the concrete level
        public override string Attack { get; set; } = "Water Cannon";
        public override string Name { get; set; } = "bulbasuar";
        public override int Health { get; set; } = 100;
    }
}
