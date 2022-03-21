using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class RevertWordsOrderTask
    {
        public static string RevertWordsOrder(string str)
        {
            string[] strArray = str.Split(' ');
            int len = strArray.Length;

            for (int i = 0; i < len / 2; i++)
            {
                string temp = strArray[i];

                if (i == 0)
                {
                    strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
                    strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);
                }
                else
                {
                    strArray[i] = strArray[len - 1 - i];
                    strArray[len - 1 - i] = temp;
                }
            }

            return string.Join(" ", strArray);
        }
    }
}
