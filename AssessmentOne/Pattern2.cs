using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class NumberPattern
    {
        public static void Main21(String[] args)
        {
            int n = 3;
            int num; 

            
            for (int i = 1; i <= n; i++)
            {
                num = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }


            for (int i = n - 1; i >= 1; i--)
            {
                num = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}

