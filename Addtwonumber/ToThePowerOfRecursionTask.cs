using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ToThePowerOfRecursionTask
    {
        public static int ToThePowerOfRecursion(int b, int exp)
        {
            return exp == 0 ? 1 : exp > 1 ? b * ToThePowerOfRecursion(b, exp - 1) : b;
        }
    }
}
