using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//while loop
namespace IntroductiontoCSharpBasics
{
    class WhileLopp
    {
        public static void Main11()
        {
            Console.WriteLine("Enter a target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write(start + " ");
                start = start + 2;  //terminating condition
            }
        }
    }
}
