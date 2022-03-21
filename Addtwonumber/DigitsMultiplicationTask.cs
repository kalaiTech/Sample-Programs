using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class DigitsMultiplicationTask
    {
        public static int DigitsMultiplication(int num)
        {
            return num > 10 ? num % 10 * DigitsMultiplication(num / 10) : num % 10;
        }
    }
}
