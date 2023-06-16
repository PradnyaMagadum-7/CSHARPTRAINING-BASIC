using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    internal class ExceptionHandling
    {
        public static void Main15()
        {
            try
            {
                //int[] arr = { 1, 2, 3, 4, 5, 6, 7};

                //Console.WriteLine(arr[9]);
                String str = null;
                Console.WriteLine(str.Length);


            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
