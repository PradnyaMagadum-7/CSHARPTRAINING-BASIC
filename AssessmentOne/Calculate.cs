using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Maths1
{

    public static void CalculateSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Result of sum :{0}", sum);
    }

    public static void Average(int a, int b)
    {
        int avg = (a + b)/2;
        Console.WriteLine("Average :{0}",avg);
    }

    public static void Substract(int a, int b)
    {
        int substract = a - b;
        Console.WriteLine("Substraction :{0}", substract);

    }

}



class Calculations
{
    public static void Main20(String[] args)  //main9
    {

        Console.WriteLine("Enter any two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());


        Maths1.CalculateSum(num1, num2);
        Maths1.Substract(num1, num2);
        Maths1.Average(num1, num2);


    }
}
