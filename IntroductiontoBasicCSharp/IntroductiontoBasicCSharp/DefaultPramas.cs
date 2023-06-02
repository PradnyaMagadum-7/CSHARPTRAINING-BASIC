using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class DefaultPramas
    {
        public static void Main7()
        {
            AddNumbers(10, c:2);   //named parameters
        }

        public static void AddNumbers(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}", b);
            Console.WriteLine("c={0}", c);
        }
    }
}
