using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//quetion4
//using string
//namespace AssessmentOne
//{
//    internal class StringConcatination
//    {
//        public static void Concat(string a, string b) 
//        {

//            string result = a + b;
//            Console.WriteLine("Concatenated string: " + result);
//        }

//        public static void Main5(string[] args)
//        {
//            Console.WriteLine("Enter the first string: ");
//            string str1 = Console.ReadLine();

//            Console.WriteLine("Enter the second string: ");
//            string str2 = Console.ReadLine();

//            Concat(str1, str2);

//        }
//    }
//}

namespace AssessmentOne
{
    internal class StringConcatination
    {
        public static void Concat(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            sb.Append(b);
            Console.WriteLine("NewString :" + sb.ToString());
        }

        public static void Main5(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine();

            Concat(str1, str2);

        }
    }
}