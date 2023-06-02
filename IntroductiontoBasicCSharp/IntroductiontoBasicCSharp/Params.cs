using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class Params  //use when programmer dont have prior knowledge of number of params
    {
        public void displayMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
        public static void Main8()
        {
            Params pm = new Params();
            pm.displayMarks(10, 20, 30, 40);
        }

    }
}
