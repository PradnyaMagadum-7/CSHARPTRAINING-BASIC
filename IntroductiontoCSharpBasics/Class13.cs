using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Customer
{
    public abstract void Print();
   
}

public class Program : Customer
{
    public override void Print()    //implementation of abstract method // if we dont ovverride it then class will become abstract
    {
        Console.WriteLine("Print Method");
    }
    public static void Main13()
    {
        Customer c1 = new Program();   //parent refrence , and base class object
        c1.Print();  
    }
}

//abstract class cannot be sealed
//it can be used as base class but sealed cannot be used as base class
