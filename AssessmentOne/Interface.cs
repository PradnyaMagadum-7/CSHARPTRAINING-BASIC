using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Question1//part second
namespace Assessment1
{
    internal class Interface
    {
        static void Main2()
        {
            Class1 o = new Class1();
            //methodcall
            o.Insert();
            o.Display();
            o.Update();
            o.Delete();



        }
    }

    public interface IDbFunctions
    {
        //all abstrct and public by default
        void Insert();
        void Update();
        void Delete();

    }
    public class Class1 : IDbFunctions
    {
        //have to inherit
        public void Delete()
        {
            Console.WriteLine("idb.delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("idb.insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("idb.update from class1");
        }
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
    }

}
