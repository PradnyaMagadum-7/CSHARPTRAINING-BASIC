using System;


namespace IntroductiontoCSharpBasics
{
    internal class Program
    {
        static void Main1()
        {
            int i = 0;

            //SimpleMethod(i);//value type
            SimpleMethod(ref i);//refernce type

           Console.WriteLine(i);
        }

        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
    }
}
