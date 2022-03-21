using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ToThePowerOfTask
    {
       public  static double ToThePowerOf(int b, int exp)
        {
            double result = 1;
            if (exp == 0)
            {
                return 1;
            }

            for (int i = 1; exp > 0 ? i <= exp : i <= exp * (-1); i++)
            {
                result *= b;
            }

            return exp > 0 ? result : 1 / result;
        }
    }
}
