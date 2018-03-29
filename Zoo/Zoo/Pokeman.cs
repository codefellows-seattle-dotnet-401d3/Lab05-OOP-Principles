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

        // Need to test out problems and see if you can 
        //one assert per method. 
        //Assert.Equal(expect, result);
        //dragon can jump.
        //Weak aginst as a propertiy 
        //Can fly( Change to Virtual)
        //++++++++
        // 

    }
}
