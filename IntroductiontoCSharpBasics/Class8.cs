using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
    class switchCase1
    {
        public static void Main8()
        {
            Console.WriteLine("Enter any number of your choice");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 10:         
                case 20: 
                case 30:
                    Console.WriteLine("num is {0}", num);
                    break;
                default:
                    Console.WriteLine("num is not in range of 10 to 30");
                    break;

            }
        }

    }
}