using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    //here it is giving error as default methods are in version 8.0 not in 7.0
    interface AB
    {
        void showA();

        //public void addNum(int num)
        //{
        //    Console.WriteLine(num);
        //}
    }
    internal class DefaultInterfaceMethod : AB //virtual extension methods
    {
        public void showA()
        {
            Console.WriteLine("Interface A method");
        }

        static void Main10()
        {
            DefaultInterfaceMethod obj = new DefaultInterfaceMethod();
            obj.showA();

            //A obj2 = new DefaultInterfaceMethod();
            //obj2.addNum(11);
        }
    }
}
