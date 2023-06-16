using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    class Program
    {
       public static void Main16()
        {
            int i, j;
            for (i = 1; i <= 3; i++) 
            {
                for (j = 2; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

