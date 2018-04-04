using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public abstract class Attraction
    {
        public abstract string Name
        {
            get;
        }
        public abstract string Type { get; }
        public abstract int HP { get; set; }
        protected virtual bool Hostile { get; set; } = false;

        public abstract string Feed(int count, int hunger);
        public abstract void Transport();

        protected virtual int Eat(int hunger)
        {
            //Reduce hunger when fed
            return hunger;
        }
    }
}
