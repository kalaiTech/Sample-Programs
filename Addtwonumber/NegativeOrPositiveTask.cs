using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class NegativeOrPositiveTask
    {
        public static double NegativeOrPositive(double num)
        {
            return num < 0 ? Math.Pow(num, 2) : Math.Sqrt(num);
        }
    }
}
