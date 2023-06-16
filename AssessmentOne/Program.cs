using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{

        internal class Loop
        {
            public static void DisplayMarks(int a)
            {
                if (a > 40)
                {
                    Console.WriteLine("Number :{0}",a+"Win");
                }
                else
                {
                    Console.WriteLine("Number :{0}", a + "Loose");
                }
            }
            public static void Main8()
            {
                Console.WriteLine("Enter any number between 0 to 100: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                DisplayMarks(num1);
                
            }

        }
    
}
