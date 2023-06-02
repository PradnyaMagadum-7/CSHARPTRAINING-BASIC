using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//split the implemention of class, interface, struct or methods into multiple file using partial keyword
//Compiler will combine all the implememtations at the last
namespace IntroductiontoBasicCSharp
{
    public partial class Student
    {
        public int id;
        public string name;

        public Student(int ID, string NAME)
        {
            this.id = ID;
            this.name = NAME;
        }

       // public partial void displayStudents();//it would not work here bcoz of older version
    }

    public partial class Student
    {
        //public partial void displayStudnts()
        //{
        //    Console.WriteLine("ID :" + id);
        //    Console.WriteLine("NaAME :" + name);
        //}
    }


    class TestProgram
    {
        public static void Main()
        {
            Student pc = new Student(101, "Pradnya");
           // pc.displayStudents();

        }
    }
}
    

