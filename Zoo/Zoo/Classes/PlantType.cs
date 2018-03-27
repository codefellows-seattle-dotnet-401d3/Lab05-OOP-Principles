using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class PlantType: Pokeman // inherits from pokeman
    {
        public override int Height { get; set; } = 150;
        public override int Weight { get; set; } = 150;
        public override int HitPoints { get; set; } = 150;
        public override String Attack { get; set; } = " Vine Whip";


        public virtual string FireWeakness() => "This Pokeman dose not like Fire";
       
    }
}
