using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Pokeman
    {

        public abstract int Height { get; set; }
        public abstract int Weight { get; set; }
        public abstract int HitPoints { get; set;}
        public abstract string Attack { get; set; }

        public abstract bool CatchThemAll();

    }
}
