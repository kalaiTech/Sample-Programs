using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise
{
    class AlmostOnlyLettersTask
    {
        public static bool AlmostOnlyLetters(string word)
        {
            Regex regex = new Regex(@"^[A-Za-z\s]+\.$");
            Match match = regex.Match(word);

            return match.Success;
        }

    }
}
