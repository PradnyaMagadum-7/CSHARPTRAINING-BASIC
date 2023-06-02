using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; 
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class Optional_Attributes //these arenot complusory parameters //not necessary to pass all parameters in the method         
    {
        public static void Main7()
        {
            AddNumbers(10, 20);
        }

        public static void AddNumbers(int n, int m, [Optional]int[] restNums)
        {
            int result = n + m;
            if (restNums != null)
            {
                foreach (int i in restNums)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}//named parameters >>> we dont need to worry about the order or sequence of parameters while calling the method
