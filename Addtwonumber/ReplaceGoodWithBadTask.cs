using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise
{
    class ReplaceGoodWithBadTask
    {
        public static string ReplaceGoodWithBad(string word)
        {
            string output = string.Empty;
            return output = Regex.Replace(word, @"((G|g)(O|o){2}(D|d))", "bad");
        }

    }
}
