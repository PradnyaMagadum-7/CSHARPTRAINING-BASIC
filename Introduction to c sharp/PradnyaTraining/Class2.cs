using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//access modifiers
public class customer
{
    private int id;

    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
}

public class  mainClass
{
    private static void Main3()
    {
        customer c1 = new customer();
            Console.WriteLine(c1.ID);
    }
}


//private : only within the class
//protected : Access is limited to the containing class or any class derived from the containing class
//public: anywhere
//internal: Access is limited to the current assembly.
//protected internal: Access is limited to the current assembly or types derived from the containing class.
