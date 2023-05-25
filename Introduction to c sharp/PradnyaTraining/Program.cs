using System;
//Escape sequence

namespace String
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string Name = "\"Program\"";
            Console.WriteLine(Name);
            string Name1 = "Pradnya\nMagadum\n";
            Console.WriteLine(Name1);
            string Name2 = "F:\\Atrina";
                Console.WriteLine(Name2);
            string Name3 = @"F:\\Atrina"; //if we put @ in front of string the escape charachters dosn't treat as same
                                           //called verbatim literal
            Console.WriteLine(Name3);
        }
    }
}
