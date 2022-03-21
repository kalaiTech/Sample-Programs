using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Two7sNextToEachOtherTask
    {
       public  static int Two7sNextToEachOther(int[] arr)
        {
            int adjacent7s = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    adjacent7s++;
                }
            }

            return adjacent7s;
        }
    }
}
