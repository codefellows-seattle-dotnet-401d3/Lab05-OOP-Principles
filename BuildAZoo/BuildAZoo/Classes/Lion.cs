using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Lion : Mammal
    {
        public override bool Carnivore { get; set; } = true;
        public override string FurColor { get; set; } = "yellow";
        public override bool HasHorns { get; set; } = false;

        public override string Eat()
        {
            return "Eating a steak";
        }

        public override string Sleep()
        {
            return "ZZZZ slight growl ZZZZ";
        }

        public override bool Roars()
        {
            return true;
        }

        public override int HaveBabies()
        {
            return 3;
        }
    }
}
