using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6
{
    class Pair
    {
        public int One { get; set; }
        public int Second { get; set; }
        public Pair Multiply(Pair value)
        {
            Pair pair3 = new Pair();
            if (One % 2 == 0 && Second % 2 == 0 && value.One % 2 == 0 && value.Second % 2 == 0)
            {
                pair3.One = One * value.Second;
                pair3.Second = Second * value.One;
            }
            return pair3;
        }
        public bool Multiply(Pair value, out Pair rezult)
        {
            rezult = new Pair();
            if (One % 2 == 0 && Second % 2 == 0 && value.One % 2 == 0 && value.Second % 2 == 0)
            {
                rezult.One = One * 2 * value.Second * 2;
                rezult.Second = Second * value.One;
                return true;
            }
            return false;
        }
    }
}
