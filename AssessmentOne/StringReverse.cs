using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    internal class StringReverse
    {
        public static void DisplayReverse(string str)
        {
            char [] arr = str.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();




        }
        public static void Main6()
        {
            string str = "Pradnya";

            DisplayReverse(str);
        }
    }
}
