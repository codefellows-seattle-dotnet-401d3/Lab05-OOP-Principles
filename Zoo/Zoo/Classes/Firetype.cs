using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
   abstract class Firetype : Pokeman // this is the inheritance thru pokeman
    {
        public override int Height { get; set; } = 100;
        public override int Weight { get; set; } = 100;
        public override int HitPoints { get; set; } = 100;
        public override String Attack { get; set; } = "fire blast";


        public virtual string WaterWeakness() => "This Pokeman dose not like water";
        public virtual string Flying() => "This Pokeman can Fly";

        //take out abstract methods in the concrete methods NOT 
        //allowed to have abstract methods in abstract classes. 
        // 
    }
}
