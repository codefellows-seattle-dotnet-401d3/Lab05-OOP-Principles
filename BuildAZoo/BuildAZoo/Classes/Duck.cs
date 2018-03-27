using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Duck : Avian
    {
        public override int NumberOfLegs { get; set; } = 2;
        public override bool Carnivore { get; set; } = true;
        public override bool HasWings { get; set; } = true;

        public override string Eat()
        {
            return "Eating little fish and bread";
        }

        public override string Sleep()
        {
            return "ZZZZ Quack ZZZZ";
        }

        public override string Caws()
        {
            return "Quack";
        }

        public override bool Fly()
        {
            return true;
        }
    }
}
