using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ToLowerOrToUpperTask
    {
        public static string ToLowerOrToUpper(string word)
        {
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = i % 2 == 0 ? words[i].ToUpper() : words[i].ToLower();
            }

            return String.Join(" ", words);
        }
    }
}
