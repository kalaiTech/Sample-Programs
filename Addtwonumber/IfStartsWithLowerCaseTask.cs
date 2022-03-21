﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class IfStartsWithLowerCaseTask
    {
        public static string IfStartsWithLowerCase(string word)
        {
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsLower(words[i][0]))
                {
                    words[i] = words[i].Substring(1);
                }
            }

            return String.Join(" ", words);
        }
    }
}
