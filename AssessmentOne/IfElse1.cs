using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    internal class Loop2
    {
        public static Boolean DisplayMarks1(int a)
        {
            if (a < 40)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Main13()
        {
            Console.WriteLine("Enter any number between 0 to 100: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Boolean b1 = DisplayMarks1(num1);
            Console.WriteLine(b1);
        }

    }
}
