using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharpBasics
{
    class Loops
    {
        public static void Main12()
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            foreach(int k in arr)   //iterate through the collection
            {
                   Console.WriteLine(k);
            }
                
            for(int i = 0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            int j = 0;
            while(j<arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
        }
    }
}

//for is used to get out of the loop
//continue>> modification statatement