using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Python : Snake
    {
        public override string Eat()
        {
            return "Eating small rodents";
        }

        public override string Sleep()
        {
            return "SSSSSS ZZZZZZZ SSSSSSS ZZZZZZ";
        }

        public override bool Slither()
        {
            return true;
        }

        public override bool LayEggs()
        {
            return true;
        }

        public override string Hisses()
        {
            return "HHHHHHIIIIIIISSSSSSSSSSSSSSSSSSSSSS";
        }
    }
}
