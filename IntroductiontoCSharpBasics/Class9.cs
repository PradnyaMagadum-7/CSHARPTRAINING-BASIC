using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
    class switchCase2
    {
        public static void Main9()
        {
            int TotalCoffeeCost = 0;

            Start:
            Console.WriteLine("1 - small, 2-medium, 3-large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2; ;
                    break;
                case 3:
                    TotalCoffeeCost += 3; ;
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid",userChoice);
                    break;

            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee");
            string userDescision = Console.ReadLine();

            switch(userDescision.ToUpper())
            {
                case "YES":
                    goto Start;
                    //break >> unreachable
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your number {0} is invalid. Please try again.");
                     goto Decide;
            }

            Console.WriteLine("Bill Amount = {0}",TotalCoffeeCost);
        }

    }
}