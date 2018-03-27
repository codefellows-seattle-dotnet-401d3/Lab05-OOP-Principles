using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Poke_man
{
    class Ivysaur : Classes.PlantType
    {
        public override int Height { get; set; } = 180;
        public override int Weight { get; set; } = 180;
        public override int HitPoints { get; set; } = 180;
        public override String Attack { get; set; } = "Solar Blast";


        //public override abstract bool CatchThemAll(true);

        public override bool CatchThemAll()
        {
            return true;
        }
    }
}
