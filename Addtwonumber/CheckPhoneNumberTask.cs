using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise
{
    class CheckPhoneNumberTask
    {
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+\d{2}\s(\d{3}\-){2}(\d{3})");
            Match match = regex.Match(phoneNumber);

            return match.Success;
        }
    }
}
