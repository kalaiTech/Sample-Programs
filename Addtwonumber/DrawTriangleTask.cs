using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class DrawTriangleTask
    {
       public  static void DrawTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k >= 10 - i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
