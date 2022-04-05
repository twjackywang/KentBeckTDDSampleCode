using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiple)
        {
            //Amount *= multiple;
            return new Dollar(Amount * multiple);
        }
    }
}
