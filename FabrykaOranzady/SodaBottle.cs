using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaOranzady
{
    class SodaBottle //factory
    {
        SodaBottle flavouredSoda;

        public SodaBottle(TASTE taste) {
            switch (taste)
            {
                case TASTE.LEMON:
                    flavouredSoda = new LemonSoda();
                    break;
                case TASTE.MANDARINE:
                    flavouredSoda = new MandarineSoda();
                    break;
                case TASTE.ORANGE:
                    flavouredSoda = new OrangeSoda();
                    break;
            }
        }

        public SodaBottle() {
            flavouredSoda = null;
        }
    }
}
