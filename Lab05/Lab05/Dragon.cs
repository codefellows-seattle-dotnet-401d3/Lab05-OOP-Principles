using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Dragon : Fiend, IDarkvision, ITremorSense
    {
        public override string Name { get; } = "Dragon";
        public override int HP { get; set; } = 120;
        public override string SubType { get; set; } = "Dragon";
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

        public string Lowlight()
        {
            //Can see in lowlight
            return "Lowlight";
        }

        public string Darvision()
        {
            //Can see in the dark
            return "darkcision";
        }

        public string Dig()
        {
            //Can dig and burrow
            return "burrow";
        }

        public string TremorSense()
        {
            //Can "see" through the ground
            return "blindsight";
        }
    }
}
