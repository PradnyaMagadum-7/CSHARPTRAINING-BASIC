using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IntroductiontoBasicCSharp
{
    interface A
    {
        void showA();
    }

    interface B : A
    {
        void showB();
    }
    internal class InheritanceInterface
    {
        public void showA()
        {
            Console.WriteLine("Interface A Method");
        }

        public void showB()
        {
            Console.WriteLine("Interface B Method");
        }
        public static void Main9()
        {
            InheritanceInterface ir = new InheritanceInterface();
            ir.showA();
            ir.showB();
        }
    }
}
