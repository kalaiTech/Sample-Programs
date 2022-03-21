using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class TheBiggestNumberTask
    {
        public static int TheBiggestNumber(int[] numArr)
        {
            int theBiggest = numArr[0];

            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] > theBiggest)
                {
                    theBiggest = numArr[i];
                }
            }

            return theBiggest;
        }
    }
}
