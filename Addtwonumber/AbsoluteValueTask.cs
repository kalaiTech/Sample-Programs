using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class AbsoluteValueTask
    {
        public int AbsoluteValue(int number)
        {
            return number >= 0 ? number : number * -1;
        }
    }
}
