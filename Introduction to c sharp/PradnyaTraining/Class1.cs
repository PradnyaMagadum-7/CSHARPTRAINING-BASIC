using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    internal class Class1
    {
        static void Main2()
        {
            int i = 100;

            float f = i;

            System.Console.WriteLine(f); //Implicit conversion>>no data loss >> no exception 

            float f1 = 123.45f;

            //int k = (int)f1; //typecasting 

            int k = Convert.ToInt32(f1); //convert class >> we get exceptions 
            Console.WriteLine(k);

            string strNum = "100";

            int i1 = int.Parse(strNum); //convert string to integer
            Console.WriteLine(i1);

           string strNum1 = "100PM";
            //string strNum1 = "1000";
            int result = 0;
            bool isConversionSuccessful = int.TryParse(strNum1, out result); //convert string to integer and store into  variable result
                                                                    //return type is boolean

            if(isConversionSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
            
        }

    }
}
