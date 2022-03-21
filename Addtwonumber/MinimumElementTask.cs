using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class MinimumElementTask
    {
        public static int MinimumElement(int[] arr, int size)
        {
            if (size == 1)
            {
                return arr[0];
            }

            return arr[size - 1] < MinimumElement(arr, size - 1) ? arr[size - 1] : MinimumElement(arr, size - 1);
        }
    }
}
