using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    //flexible mechanism that provides the flexible mechanism for classes to access the private fields
    //hase two accessor>>>1. get ----returns a property value
    //                         set ---assigns a new value
    //value keyword represents value of a property
    //it can be>>> read- writye, read- only and write only
    internal class Property
    {
        static int empId;

        public static int EmpID
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }

        public static void Main8()
        {
            Property.EmpID = 101;//Accessing static props
            Console.WriteLine(Property.EmpID);
        }
            
    }
}
