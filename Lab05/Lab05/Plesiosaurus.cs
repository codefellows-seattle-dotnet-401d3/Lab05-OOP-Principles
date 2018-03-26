using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Plesiosaurus : Beast
    {
        public override string Name { get; } = "Plesiosaurus";
        public override int HP { get; set; } = 68;
        public override string Climate { get; } = "Aquatic";
        public override bool Hostile { get => base.Hostile; set => base.Hostile = value; }
        public override bool Enchanted { get => base.Enchanted; set => base.Enchanted = value; }

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

        public override string Diet()
        {
            //Pull idet from archive
            string kibble = "kibble";
            return kibble;
        }

        public override string Enclosure(string materialType)
        {
            return base.Enclosure(materialType);
        }
    }
}
