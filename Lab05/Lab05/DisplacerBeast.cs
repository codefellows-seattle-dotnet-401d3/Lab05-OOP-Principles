using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class DisplacerBeast : Monstrosity
    {
        public override string Name { get; } = "DisplacerBeast";
        public override int HP { get; set; } = 42;
        public override string Immunity { get; set; } = "Fire, Poison";
        public override string NativePlane => base.NativePlane;
        public override bool Hostile { get => base.Hostile; set => base.Hostile = value; }

        public override int ThreatLevel(int strength)
        {
            return base.ThreatLevel(strength);
        }

        public override string Feed(int count, int hunger)
        {
            if (count > hunger)
            {
                return "Satisfied";
            }
            else
            {
                return "Hungry";
            }
        }

        public override void Transport()
        {
            //How to transport
        }
    }
}
