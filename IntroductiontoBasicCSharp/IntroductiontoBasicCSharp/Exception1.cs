using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
   public class Exception1
    {
        public static void Main2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Enjoy y0ur program");
        }
    }
}