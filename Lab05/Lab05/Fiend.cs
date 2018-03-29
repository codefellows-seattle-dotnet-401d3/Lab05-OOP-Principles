using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public abstract class Fiend : Monstrosity
    {
        abstract public string SubType { get; set; }
        protected virtual string Immunites { get; set; } = "None";

        public abstract string[] Abilities();

        public override int ThreatLevel(int strength)
        {
            return base.ThreatLevel(strength);
        }
    }
}
