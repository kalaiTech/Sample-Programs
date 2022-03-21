using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class MixTwoStringsTask
    {
        public static string MixTwoStrings(string word1, string word2)
        {
            string mixedWord = string.Empty;

            for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
            {
                if (i < word1.Length)
                {
                    mixedWord += word1[i];
                }
                if (i < word2.Length)
                {
                    mixedWord += word2[i];
                }
            }

            return mixedWord;
        }
    }
}
