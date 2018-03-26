using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Animal
    {
        public abstract int NumberOfLegs { get; set; }
        public abstract bool Carnivore { get; set; }

        public abstract string Eat();
        public abstract string Sleep();
    }
}
