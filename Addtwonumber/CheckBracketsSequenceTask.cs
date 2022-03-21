using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class CheckBracketsSequenceTask
    {
       public  static bool CheckBracketsSequence(string sequence)
        {
            int check = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                check = sequence[i] == '(' ? ++check : --check;
            }

            return check == 0;
        
        }
    }
}
