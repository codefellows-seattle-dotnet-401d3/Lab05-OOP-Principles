using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Snake : Reptile
    {
        public override int NumberOfLegs { get; set; } = 0;
        public override bool Carnivore { get; set; } = true;
        public override bool LooksSlimey { get; set; } = true;

        public abstract string Hisses();
    }
}
