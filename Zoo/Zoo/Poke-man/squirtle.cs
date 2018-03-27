using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Poke_man
{
    class squirtle : Classes.WaterType
    {
        public override int Height { get; set; } = 180;
        public override int Weight { get; set; } = 180;
        public override int HitPoints { get; set; } = 180;
        public override String Attack { get; set; } = "water gun";


        //public override abstract bool CatchThemAll(true);

        public override bool CatchThemAll()
        {
            return true;
        }
    }
}
