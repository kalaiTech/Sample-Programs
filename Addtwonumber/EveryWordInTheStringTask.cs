using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace exercise
{
    class EveryWordInTheStringTask
    {
        public static bool EveryWordInTheString(string word)
        {
            Regex regex = new Regex(@"^([A-Z]\w*\s*)+\W*$");
            Match match = regex.Match(word);

            return match.Success;
        }

    }
}
