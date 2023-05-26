using System;

//parameter arrays

namespace IntroductiontoCSharpBasics
{
    internal class Class2
    {
        public static void Main3()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //ParamMethod(); //we have used params keyword so that it will not happen anything if we will not pass anything here
            //ParamMethod(Numbers);
            ParamMethod(10, 20, 30, 40, 50);
        
        }

        public static void ParamMethod(params int[] Numbers) //to create parameter arrays
        {
            Console.WriteLine("There are {0} elements in the arrays :",Numbers.Length); ///gives total number of elements in the array
            
            foreach(int i in Numbers) //to traverse
            {
                Console.WriteLine(i);
            }
        
        }
    }
}
