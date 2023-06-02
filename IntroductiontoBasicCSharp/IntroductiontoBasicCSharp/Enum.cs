using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
     class Enum
    {
        public static void Main11()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Pradnya",
                Gender = Gender.Female
            };

            customers[1] = new Customer
            {
                Name = "Riddhi",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Vishwaraj",
                Gender = Gender.Male
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer name = {0} && Customer's Gender = {1}",customer.Name, getGender(
                    customer.Gender));
            }

        }

        public static string getGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.unknown:
                    return "unknown";
                case Gender.Female:
                    return "Female";
                case Gender.Male:
                    return "male";
                default:
                    return "Invalid data detected";
            }
        }

        public enum Gender
        {
            unknown,
            Female,
            Male
        }

        public class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
        }


    }
}
