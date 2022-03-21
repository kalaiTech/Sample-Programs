using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class IsPalindromeRecursionTask
    {
       public  static bool IsPalindromeRecursion(string str)
        {
            if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
            {
                return true;
            }
            else if (str.Length > 1)
            {
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }

                return IsPalindromeRecursion(str.Substring(1, str.Length - 2));
            }

            return false;
        }

    }
}
