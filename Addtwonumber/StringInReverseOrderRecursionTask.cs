using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class StringInReverseOrderRecursionTask
    {
       public  static string StringInReverseOrderRecursion(string str)
        {
            return str.Length > 0 ? str[str.Length - 1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
        }

 
    }
}
