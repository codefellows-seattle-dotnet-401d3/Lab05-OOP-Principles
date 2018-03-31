using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes.zoo
{
    public abstract class Animals
    {
        public virtual string Food { get; set; }
        public enum Sleep { day,
                            night,
                            diurnal
                           };
        public enum Size { tiny,
                           small,
                           medium,
                           big,
                           huge
                         };
        public virtual int Cute { get; set; } // 0-10 ranking
        public virtual int Noble { get; set; } // 0-10 ranking

        public abstract void Speak();
        public abstract void CleanUp();
        public abstract void Bury();
        

    }
}
