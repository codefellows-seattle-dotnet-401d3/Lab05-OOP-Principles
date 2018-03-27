using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public abstract class Beast : Attraction
    {
        public override string Type { get; } = "Beast";
        public abstract string Climate { get; }
        public virtual bool Enchanted { get; set; } = false;

        public virtual string Enclosure(string materialType)
        {
            return materialType;
        }

        public abstract string Diet();
    }
}
