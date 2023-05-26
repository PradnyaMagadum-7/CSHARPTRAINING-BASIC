using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Customer1  //abstrct class memners are private by default
{
    int ID; //Abstract class contain fields
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer   //interface methods are public by default and they cant have access modifiers
{
    //int ID; //interface cannot contain fields
    void Print();
    
}

public class Program : Customer1
{
 
}


//abstrct class can inherit from another abstrct class or interface
//interface can inherit from another interface only
//class can inherit from multiple interfaces , class cannot inherit from multiple classes at the same time.