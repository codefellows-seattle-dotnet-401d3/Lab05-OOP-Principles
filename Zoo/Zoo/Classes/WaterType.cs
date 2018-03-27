using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class WaterType : Pokeman // inherits from pokeman
    {
        public override int Height { get; set; } = 150;
        public override int Weight { get; set; } = 150;
        public override int HitPoints { get; set; } = 150;
        public override String Attack { get; set; } = " Water Blast";


        public virtual string PlantWeakness() => "This Pokeman hates plant life";
    }
}
