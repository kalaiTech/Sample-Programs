using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class HowManyOccurrencesTask
    {
       public  static int HowManyOccurrences(string str, string subStr)
        {
            int found;
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                found = str.IndexOf(subStr, i);

                if (found > -1)
                {
                    total++;
                    i = found;
                }
            }

            return total;
        }
    }
}
