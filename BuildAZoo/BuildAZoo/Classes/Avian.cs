using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Avian : Animal
    {
        public virtual bool HasWings { get; set; } = true;

        public abstract bool Fly();
        public virtual string Caws()
        {
            return "Caw";
        }
    }
}
