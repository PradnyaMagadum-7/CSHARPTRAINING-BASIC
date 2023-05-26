using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  //string builder present here
using System.Threading.Tasks;

//namespace IntroductiontoCSharpBasics
//{
//    public class MainClass
//    {
//        public static void Main()
//        {
//            string useString = " C# ";
//            useString += " Tutorial ";
//            useString += " Learning ";
//            useString += " for ";
//            useString += " beginners ";
//            Console.WriteLine(useString);

//        }
//    }
//}


// by using stringBuilder

namespace IntroductiontoCSharpBasics
{
    public class MainClass
    {
        public static void Main6()
        {
            StringBuilder useString = new StringBuilder("C#");
            useString.Append(" Tutorial ");
            useString.Append(" Learning ");
            useString.Append(" for ");
            useString.Append(" beginners ");
            Console.WriteLine(useString.ToString());

        }
    }
}
// for havy string manupulation its better to use string builder
//string >> mutable
//>> string builder >> immutable