using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public abstract class Monstrosity : Attraction
    {
        public override string Type { get; } = "Monstrosity";
        public abstract string Immunity { get; set; }
        public virtual string NativePlane { get; } = "Material";

        public virtual bool Contained(bool weaknessKnown)
        {
            if (!weaknessKnown)
            {
                return false;
            }
            return true;
        }

        public virtual int ThreatLevel(int strength)
        {
            return 10 - strength;
        }
    }
}
