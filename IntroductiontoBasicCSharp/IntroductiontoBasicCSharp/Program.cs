using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            task1();
            task2();
            task3();   //calling as per calling sequence
                        //when we apply aync and await on it then jiska time kam hoga vahi pahale exwcute hoga
            Console.ReadLine();
        }

        public static async void task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task one started");
                Thread.Sleep(4000);
                Console.WriteLine("Task one completed");
            });  //ye jo task hain vo delay karega // await jaha lagaya vo line suspend ki jayegi for a while
            
           
        }

        public static async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task two started");
                Thread.Sleep(3000);
                Console.WriteLine("Task two completed");
            });
            Console.WriteLine("Hello Pradnya");

        }

        public static async void task3()
        {
            await Task.Run(() =>   //asynchronus ke liye task class ham apply karate hain single opration ko perform karane keliye
            {
                Console.WriteLine("Task three started");
                Thread.Sleep(1000);
                Console.WriteLine("Task three completed");
            });
          
        }
    }
}
//while selecting buttons 
//aysnc and await helpus to program asynchronously
//Async>>>> is a method performs asynchronus tasks such as to perform a data fetching from database,readinga file,(task which create delay).
//jis line ke pahale await keyword hota hain vo ussko thodi der ke liye suspend kar deta hain until asynchronus task gets completed
//after suspension control goes back to the caller method   at await and execute the remaining task