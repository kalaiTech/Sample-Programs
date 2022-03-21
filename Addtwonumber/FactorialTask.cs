using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class FactorialTask
    {
        public static long Factorial(int num)
        {
            return num == 0 || num == 1 ? 1 : num * Factorial(num - 1);
        }
    }
}
