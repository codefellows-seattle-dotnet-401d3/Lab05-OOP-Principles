using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Avian : Animal
    {
        public virtual bool HasWings { get; set; } = true;

        public abstract string Caws();
        public abstract bool Fly();
    }
}
