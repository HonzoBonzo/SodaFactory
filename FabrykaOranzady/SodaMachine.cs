using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaOranzady
{
    public sealed class SodaMachine //singleton
    {
        private static SodaMachine instance = null;
        

        private SodaMachine() { }

        public static SodaMachine Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SodaMachine();
                }
                return instance;
            }

        }

        internal SodaBottle createBottleAndFillWithSoda(TASTE taste)
        {
            return new SodaBottle(taste);
        }
    }
}
