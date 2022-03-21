using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class SortCharactersDescendingTask
    {
        public static char[] SortCharactersDescending(string str)
        {
            char[] charArray = str.ToCharArray();
            char ch;

            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (charArray[j] < charArray[j + 1])
                    {
                        ch = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = ch;
                    }
                }
            }

            return charArray;
        }   
    }
}
