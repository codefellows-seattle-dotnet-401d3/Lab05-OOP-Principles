using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs.NewFolder
{
    class Ivysauer : Planttype
    {
        public override string Name { get; set; } = "Ivysauer";

        public override string CanEvolve()
        {
            Console.WriteLine("This pokemon is alreay evolved");
            return "No";
        }
    }
}
