using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Monkey : Beast
    {
        public override string Name { get; } = "Monkey";
        public override int HP { get; set; } = 12;
        public override string Climate { get; } = "Arborial";
        protected override bool Hostile { get => base.Hostile; set => base.Hostile = value; }
        protected override bool Enchanted { get => base.Enchanted; set => base.Enchanted = value; }

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
            string kibble = "bannanas";
            return kibble;
        }

        public override string Enclosure(string materialType)
        {
            return base.Enclosure(materialType);
        }
    }
}
