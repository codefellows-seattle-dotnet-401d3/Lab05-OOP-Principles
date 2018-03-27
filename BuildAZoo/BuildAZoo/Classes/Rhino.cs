using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Rhino : Mammal
    {
        public override bool Carnivore { get; set; } = false;
        public override string FurColor { get; set; } = "white";
        public override bool HasHorns { get; set; } = true;

        public override string Eat()
        {
            return "Eating grass, a lot of grass";
        }

        public override string Sleep()
        {
            return "ZZZZZZZZ";
        }

        public override bool Roars()
        {
            return false;
        }

        public override int HaveBabies()
        {
            return 1;
        }
    }
}
