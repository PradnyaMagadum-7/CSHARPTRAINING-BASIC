using System;

namespace TeamA
{
    class Program
    {
        public static void Main5()
        {
            ProjectA.TeamA.ClassA.Print(); //to avoid ambviguity use fully qualified name
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print Method");
            }
        }
    }
}
//Namespaces are used to organize code into logical groups 
