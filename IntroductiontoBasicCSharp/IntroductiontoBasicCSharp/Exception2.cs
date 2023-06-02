using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class ExceptionHandling
    {
        class Exception2 : Exception
        {
            public Exception2(String msg)
            {
                Console.WriteLine(msg);
            }
        }

        class Program
        {
            static void Main12()
            {
                int x = 0;

                try
                {
                    if (x == 0)
                        throw new Exception2("This is inccorect");
                }
                catch (Exception2 ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }

            }
        }

    }
}
