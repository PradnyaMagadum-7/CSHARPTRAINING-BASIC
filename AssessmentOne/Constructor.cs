using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Question2
namespace Assessment1
{
    internal class Constructor
    {
        static void Main3(string[] args)
        {

            Employee o1 = new Employee("Pradnya", 12000, 10);

            Console.WriteLine("Empno = " + o1.EmpNo + " " + "Name = " + o1.Name + " " + "Basic = " + o1.Basic + " " + "DeptNo =" + o1.DeptNo);

            Employee o2 = new Employee("Riddhi", 12000);

            Console.WriteLine("Empno = " + o2.EmpNo + " " + "Name = " + o2.Name + " " + "Basic = " + o2.Basic + " " + "DeptNo =" + o2.DeptNo);

            Employee o3 = new Employee("Vishwaraj");

            Console.WriteLine("Empno = " + o3.EmpNo + " " + "Name = " + o3.Name + " " + "Basic = " + o3.Basic + " " + "DeptNo =" + o3.DeptNo);

            Employee o4 = new Employee();

            Console.WriteLine("Empno = " + o4.EmpNo + " " + "Name = " + o4.Name + " " + "Basic = " + o4.Basic + " " + "DeptNo =" + o4.DeptNo);
        }
    }


    public class Employee
    {
        //Property
        private int empNo;

        public int EmpNo
        {
            set
            {

                empNo = value;
            }
            get
            {

                return empNo;
            }
        }

        private String name;

        public String Name
        {

            set
            {
                if (value != "")
                {
                    name = value;

                }
                else
                {

                    Console.WriteLine("Invalid Name");
                }

            }
            get
            {

                return name;
            }
        }

        private decimal basic;

        public decimal Basic
        {
            set
            {

                if (basic > 10000 & basic < 50000)
                {

                    basic = value;
                }
                else
                {

                    Console.WriteLine("Invalid Basic");

                }
            }
            get
            {

                return basic;
            }
        }

        private short deptNo;

        public short DeptNo
        {

            set
            {

                if (value > 0)
                {

                    deptNo = value;
                }
                else
                {

                    Console.WriteLine("Invalid deptno");
                }
            }
            get
            {

                return deptNo;
            }
        }

        public decimal GetNetSalary()
        {

            return basic * 2;
        }

        static int x = 0;
        public Employee(String Name = "Pooja", decimal Basic = 10001, short DeptNo = 10)
        {

            x = x + 1;
            this.EmpNo = x;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;

        }

    }
}

