using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class DigitalRootTask
    {
        public static int DigitalRoot(uint number)
        {
            while (number / 10 != 0)
            {
                uint sum = 0;
                int i = 10;
                int j = 1;

                while (number / j >= 1)
                {
                    sum += (uint)(number % i / j);

                    i *= 10;
                    j *= 10;
                }

                number = sum;
            }

            return (int)number;
        
        }
    }
}
