using IntroductiontoBasicCSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoBasicCSharp
{
    internal class InnerException
    {
        public static void Main3()
        {
            try
            {
                int num1, num2, result;

                try
                {
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    result = num1 / num2;
                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Users\ADMIN\Desktop\ABC.txt";
                    if (File.Exists(filepath))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(ex.Message);
                       // sb.Append(ex.Source);
                       // sb.Append(ex.HelpLink);
                        sb.Append(ex.StackTrace);
                        sb.Append(ex.GetType());
                        sb.Append(ex.GetType().Name);

                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(sb.ToString());
                        sw.Close();
                        Console.WriteLine("There is problem. Try again later");
                    }

                    else
                    {
                        string msg = filepath + ": " + "Does not exist";
                        throw new FileNotFoundException(msg, ex);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.StackTrace);

                if (exp.InnerException != null)
                {
                    Console.WriteLine(exp.InnerException.Message);
                    Console.WriteLine(exp.InnerException.Source);
                    Console.WriteLine(exp.InnerException.StackTrace);

                }
            }
            Console.WriteLine("End of main");
            Console.ReadLine();
            }
 
        }
    }


//>>>>>Point 1: First we are asking the user to enter two numbers. In order to understand Inner Exception, we have to make sure this program causes an exception while running the application. To do that we have 3 options

//You can enter a Character instead of a number which will cause a Format Exception.
//Or, you can enter a very big number that an integer cannot hold which will cause Over Flow Exception.
//Or, you can enter zero for the Second Number which will cause the application to throw the Divide By Zero Exception.

//>>>Point 2: Once you cause your application to throw an error from the inner try block, then that error is going to be 
//handled by the Inner Catch block. This is because the inner catch is a generic catch block, taking the Exception class as a
//parameter that can capture any type of exceptions thrown from the corresponding try block.

//>>>Point 3: Once the catch block catches the exception, then we are trying to log the exception details into a text file. 
//    Here, if you are providing the correct file path, then the exception information will be logged into the text file.
//    But to understand Inner Exception, make sure that the file path does not exist. If the File Path does not exist,    
//    then we are throwing a File Not Found Exception from the catch block and if you see, we are passing two parameters 
//    to the constructor of the File Not Found Exception class. The first parameter specifies the message and the second parameter 
//    is the exception (the exception that was thrown from the inner try block) and this exception information will be stored inside 
//    the InnerException property.

//>>>>>>>Point 4: Now, the outer catch block will catch the File Not Found Exception which is thrown by the inner catch block.Here, 
//    first, we are printing the current exception details and then we are printing the original or the old exception details 
//i.e.the exception which is originally thrown from the Inner Try block.And we can access the old exception details from the Inner 
//Exception property.But before accessing the InnnerExveption properties, please make sure that the InnnerExveption value is not null,
//else you might get a Null Reference Exception.
