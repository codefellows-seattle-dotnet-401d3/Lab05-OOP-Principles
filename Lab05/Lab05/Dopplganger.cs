using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Dopplganger : Fiend
    {
        public override string Name { get; } = "DisplacerBeast";
        public override int HP { get; set; } = 68;
        public override string SubType { get; set; } = "Humanoid";
        public override string Immunity { get; set; } = "Fire, Poison";
        public override string NativePlane => base.NativePlane;
        protected override bool Hostile { get => base.Hostile; set => base.Hostile = value; }

        public override string[] Abilities()
        {
            string[] abs = new string[0];
            return abs;
        }

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
