using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class StringInReverseOrderTask
    {
        public static string StringInReverseOrder(string str)
        {
            string reverseString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            return reverseString;
        }

   
    }
}
