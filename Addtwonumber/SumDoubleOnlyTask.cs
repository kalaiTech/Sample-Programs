using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class SumDoubleOnlyTask
    {
       public  static double SumDoubleOnly(object[] obj)
        {
            double sum = 0.0;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] is double)
                {
                    sum += (double)obj[i];
                }
            }

            return sum;
        }
    }
}
