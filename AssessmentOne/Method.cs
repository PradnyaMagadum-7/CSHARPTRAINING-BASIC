using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Method overrriding and method overloading
        class Shape
        {
           
            public static void CalculateArea(int l)
            {
                double area = Math.Pow(l, 2);
                Console.WriteLine("Area of square :{0}",area);
            }

            public static void CalculateArea(int l, int b)
            {
                int area = l * b;
                Console.WriteLine("Area of rectangle :{0}", area);
            }

           public virtual void draw()
           {
                Console.WriteLine("Draw Rectangle");
           }
            
        }


        class Rectangle : Shape
        {
            public  override void draw()
            {
                Console.WriteLine("Draw square and Rectangle with given diamentiosns");
            }
        }

class Area
{
    public static void Main9(String[]args)
    {
        Rectangle rec = new Rectangle();
        rec.draw();

        
        Shape.CalculateArea(10);
        Shape.CalculateArea(10,20);
    }
}
               
                

               
  
    
