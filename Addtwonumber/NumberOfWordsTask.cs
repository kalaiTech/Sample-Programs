using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class NumberOfWordsTask
    {
        public static int NumberOfWords(string str)
        {
            int numberOfWords = 0;
            for (int i = 1; i < str.Length; i++)
            {
                numberOfWords = (char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords);
            }

            return numberOfWords + 1;
        }
    }
}
