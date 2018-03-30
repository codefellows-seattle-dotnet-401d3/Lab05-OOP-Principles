using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Poke_man
{
    class Charzoid : Classes.Firetype
    {
        public override int Height { get; set; } = 220;
        public override int Weight { get; set; } = 220;
        public override int HitPoints { get; set; } = 220;
        public override String Attack { get; set; } = "Fire Blaze";


        //public override abstract bool CatchThemAll(true);

        public override bool CatchThemAll()
        {
            return true;
        }

        private bool FlyingPokeman()
        {
            return true;
            Console.WriteLine("Charizod can fly");
        }
    }
}
