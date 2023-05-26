using System;
using System.Diagnostics.CodeAnalysis;



   class Program1
    {
        public static void Main2()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1} :",Total, Product);
         
        }

        public static void Calculate(int fn, int sn, out int sum, out int product)
        {
            sum = fn + sn;
            product = fn * sn;
        }
    }
//if we want our method to return more than one value 