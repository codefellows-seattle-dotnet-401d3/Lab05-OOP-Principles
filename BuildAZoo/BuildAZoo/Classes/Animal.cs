using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Animal
    {
        public abstract int NumberOfLegs { get; set; }
        public abstract bool Carnivore { get; set; }

        public virtual string Eat()
        {
            return "nom nom";
        }
        public virtual string Sleep()
        {
            return "snor snor";
        }
    }
}
