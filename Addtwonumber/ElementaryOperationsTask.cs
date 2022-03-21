using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class ElementaryOperationsTask
    {
        public static string ElementaryOperations(int a, int b)
        {
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            double division;

            if (b != 0)
            {
                division = a / (double)b;
            }
            else // assume that division by 0 returns 0
            {
                division = 0;
            }

            return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}");
        }

        
    }
}
