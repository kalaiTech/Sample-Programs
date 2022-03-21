using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise
{
    class DecimalDigitInformationTask
    {
        public static string DecimalDigitInformation(string word)
        {
            Regex regex = new Regex(@"\d");
            Match match = regex.Match(word);

            return match.Success ? $"Digit {match.Value} at position {match.Index}" : $"No digit found!";
        }
    }
}
