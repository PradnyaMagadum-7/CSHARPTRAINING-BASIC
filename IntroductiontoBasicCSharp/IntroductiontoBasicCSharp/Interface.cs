using areacal;
using IntroductiontoBasicCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//explicit interface is useful when class implementing multiple interfaces
namespace IntroductiontoBasicCSharp
{
    internal interface Icalculate
    {
        //interface methods are public and abstract by default
        double calculateArea(float r);
        double calculateArea(int l, int b);
    }
}         

namespace areacal
{
    internal class Shape : Icalculate
    {
        //public double calculateArea(float r)
        //{
        //    return (3.14f * r * r);
        //}

        double Icalculate.calculateArea(float r)   //public is not allowed here
        {
            return (3.14f * r * r);
        }

        double Icalculate.calculateArea(int l, int b)
        {
            return (l * b);
        }

        //public double calculateArea(int l, int b)
        //{
        //    return (l * b);
        //}

    }
}
namespace interfac
{
    internal class Interface
    {
        static void Main8()
        {
            Icalculate obj = new Shape();
            Console.WriteLine(obj.calculateArea(2.3f));
            Console.WriteLine(obj.calculateArea(3, 4));
        }
    }
}
