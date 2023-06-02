using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class MethodOverloading
    {
        public static void Main6()
        {
            AddNumbers(10, 20,null);
        }

        public static void AddNumbers(int n, int m, int[] restNums)
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
}
