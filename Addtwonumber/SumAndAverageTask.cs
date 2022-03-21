using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class SumAndAverageTask
    {
        public static string SumAndAverage(int lowest, int highest)
        {
            int sum = 0;
            int range = 0;
            double average = 0.0;
            for (int i = lowest; i <= highest; i++)
            {
                sum += i;
                range++;
            }

            average = sum / (double)range;

            return string.Format($"Sum: {sum}, Average: {average}");
        }
    }
}
