using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class NamedParameters  //we dont have to folloe the order and sequence
    {
        public void displayStudDetails(int roll, string branch, int age, string name)
        {
            Console.WriteLine("Roll Number : {0}", roll);
            Console.WriteLine("Branch : {0}", branch);
            Console.WriteLine("age: {0}", age);
            Console.WriteLine("Name : {0}", name);
        }
        public static void Main7()
        {
            NamedParameters nm = new NamedParameters();
            nm.displayStudDetails(age: 23, name: "Pradnya", branch: "Environment", roll: 59);
        }
    }
}
