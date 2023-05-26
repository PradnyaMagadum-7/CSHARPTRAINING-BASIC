using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
   public class Customer
    {
        string firstName;
        string lastName;

        public Customer(string FirstName, string LastName) //constructior
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name :{0}",this.firstName + " " + this.lastName); //methods
        }

        ~Customer()
        { //clean up code
        } //destructors
    }
    class program
    {
        public static void Main10()
        {
            Customer c1 = new Customer("Pradnya", "Magadum");
            c1.PrintFullName();
        }
    }
}
