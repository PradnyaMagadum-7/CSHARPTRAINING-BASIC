using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    internal class Percentage
    {
        public static void percentage(decimal a, decimal b)
        {
            decimal per = (a / b) * 100;
            Console.WriteLine("Percentage : {0}", per);
        }
        public static void Main7()
        {
            decimal a = 93, b = 100;
            percentage(a, b);
        }
    }
}
