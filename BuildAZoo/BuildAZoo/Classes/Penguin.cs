using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Penguin : Avian
    {
        public override int NumberOfLegs { get; set; } = 2;
        public override bool Carnivore { get; set; } = true;
        public override bool HasWings { get; set; } = true;

        public override string Eat()
        {
            return "Eating fish";
        }

        public override string Sleep()
        {
            return "ZZZZZZZZ";
        }

        public override string Caws()
        {
            return "Squawk";
        }

        public override bool Fly()
        {
            return false;
        }
    }
}
