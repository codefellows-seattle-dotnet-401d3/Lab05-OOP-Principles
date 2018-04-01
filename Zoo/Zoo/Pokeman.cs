using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Pokemon
    {

        public abstract int Health { get; set; }
        public abstract string ElementalStrength { get; set; }

 
        public abstract bool CatchThemAll();

        public string Attack()
        {
            return Attack();
        }

        public bool Catchable()
        {
            return "gotcha"
        }





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
