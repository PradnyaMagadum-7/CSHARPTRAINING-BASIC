using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
    public class mainClass
    {
        public static void Main6()
        {
            customer c1 = new customer();
            string str = c1.ToString(); //string representation of customer object
            Console.WriteLine(str);
        }
    }
}

public class customer
{
    public string Name { get; set; }
}
//toString doesnt handle null but Convert.tostring can
// string throws null refrence exception