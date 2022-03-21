using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class BitsToNumberTask
    {
        public static int BitsToNumber(string bits)
        {
            var number = 0;

            for (var i = 0; i < bits.Length; i++)
            {
                number += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i - 1));
            }

            return number;
        }
    }
}
