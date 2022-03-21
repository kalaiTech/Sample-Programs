using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class CompressString
    {
        public static string CompressStrin(string str)
        {
            var count = 0;
            var last = str[0];
            var newStr = string.Empty;

            foreach (var s in str)
            {
                if (s == last)
                {
                    count++;
                }
                else
                {
                    newStr += last.ToString() + count;
                    last = s;
                    count = 1;
                }
            }

            newStr += last.ToString() + count;

            return newStr;
        }
    }
}
