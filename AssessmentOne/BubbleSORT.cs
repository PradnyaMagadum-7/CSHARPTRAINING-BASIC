using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class BubbleSortExample
    {
        static void bubbleSort(int[] arr)
        {
            
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < (arr.Length-1); j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }

                }
            }

        }
        public static void Main17(String[] args)
        {
            int []arr = { 23, 67, 01, 99, -89 };

            foreach(int i in arr)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            bubbleSort(arr); 

            Console.WriteLine("Print array");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
