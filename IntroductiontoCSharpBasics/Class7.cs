using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
    class switchCase
    {
        public static void Main7()
        {
            Console.WriteLine("Enter any number of your choice");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 10:
                    Console.WriteLine("num is 10");
                    break;

                case 20:
                    Console.WriteLine("num is 20");
                    break;

                case 30:
                    Console.WriteLine("num is 30");
                    break;

                case 40:
                    Console.WriteLine("num is 40");
                    break;

                case 50:
                    Console.WriteLine("num is 50");
                    break;

                default:
                    Console.WriteLine("num is not in range of 10 to 50");
                    break;

            }
        }

    }
}
