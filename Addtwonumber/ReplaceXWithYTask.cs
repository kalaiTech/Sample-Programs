using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ReplaceXWithYTask
    {
        public static string ReplaceXWithY(string word)
        {
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("y"))
                {
                    words[i] = words[i].Replace("y", "x");
                }
            }

            return String.Join(" ", words);
        }
    }
}
