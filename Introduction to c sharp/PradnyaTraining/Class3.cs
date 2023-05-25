using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class customer1
{
    protected int ID;  
}

public class corporateCustomer : customer1
{
    public void PrintID()
    {
        corporateCustomer cc = new corporateCustomer();
        cc.ID = 100;
        //base.id;
        //this.id;
    }
}

public class mainClass1
{
    private static void Main4()
    {
        customer c1 = new customer();
        Console.WriteLine(c1.ID);
    }
}
