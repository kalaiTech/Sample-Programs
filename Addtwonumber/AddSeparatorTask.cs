using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class AddSeparatorTask
    {
        public static string AddSeparator(string word, string separator)
        {
            string separatedWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();
            }

            return separatedWord;
        }
    }
}
