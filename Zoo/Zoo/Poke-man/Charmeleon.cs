using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Poke_man
{
    class Charmeleon : Classes.Firetype
    {

        public override int Height { get; set; } = 120;
        public override int Weight { get; set; } = 120;
        public override int HitPoints { get; set; } = 120;
        public override String Attack { get; set; } = "fire blast";


        //public override abstract bool CatchThemAll(true);

        public override bool CatchThemAll()
        {
            return true;
        }

    }
    
}
