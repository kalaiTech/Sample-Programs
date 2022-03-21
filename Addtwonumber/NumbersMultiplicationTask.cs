using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class NumbersMultiplicationTask
    {
        public static int NumbersMultiplication(int from, int to)
        {
            while (from == to)
            {
                return from;
            }

            return from * NumbersMultiplication(from + 1, to);
        }
    }
}
