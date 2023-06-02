using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//make method parameters optional
//1. use parameter array
namespace IntroductiontoBasicCSharp
{
    internal class OptionalParameters
    {
        public static void Main5()
        {
           // AddNumbers(10, 20, 30,40,50);
           AddNumbers(10,20, new object[] {30,40,50});
        }

        public static void AddNumbers(int num1, int num2, params object[] restNumbers)
        {
            int result = num1 + num2;
            if (restNumbers != null)
            {
                foreach (int i in restNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);  
        }
    }
}
//parameter array must be the last parameter in the parameter list otherwise it will give error
