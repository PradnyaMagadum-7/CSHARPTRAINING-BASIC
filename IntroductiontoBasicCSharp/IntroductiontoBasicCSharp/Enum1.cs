using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class Nullable
    {
        public static void Main12()
        {
            int? x = null;
            //Nullable<int> y = 12;
            int y = x ?? 7;   //if x is null then assign 7 to y
            Console.WriteLine(x.GetValueOrDefault());
            // Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(y);
        }
    }
}

//nullble type allows to assign a null value to the variable
//GetValueOrDefault method gives us original assigned value if it not null and will get zero as default if it is null
//?? >>> assign nullable to non nullable types and can only be work with value types
//HasValue returns true if variable contains a value or false if itis null
    


