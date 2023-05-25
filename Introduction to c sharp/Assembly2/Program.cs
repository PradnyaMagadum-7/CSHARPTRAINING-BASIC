using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly2
{
    public class Assembly2Class1
    {
        internal int ID = 101;
    }

    public class Assembly2Class2
    {
        public void SampleMethod()
        {
            Assembly2Class1 A1 = new Assembly2Class1();
            Console.WriteLine(A1.ID);
        }
    }
}
