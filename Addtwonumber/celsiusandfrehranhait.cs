using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class celsiusandfrehranhait
    {

        public static string CtoF(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below absolute zero!";
            }

            fahrenheit = celsius * 1.8 + 32;

            return $"T = {fahrenheit}F";
        }
        
    }
}
