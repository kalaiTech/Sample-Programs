using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ReturnEvenNumbersTask
    {
        public static string ReturnEvenNumbers()
        {
            string str = string.Empty;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    str += i + " ";
                }
            }

            return str;
        }
    }
}
