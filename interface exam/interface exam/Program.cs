using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface AreaInt
{
    void calculateArea(double r,double l);

}
class circle : AreaInt
{
    public void calculateArea(double r, double l)
    {
        Console.WriteLine("Area of circle is:" + (3.14 * r * r));
    }
}
class rectangle : AreaInt
{
    public void calculateArea(double r, double l)
    {
        Console.WriteLine("Area of circle is:" + ( r * l));
    }
}
namespace interface_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.calculateArea(4.2,0);
            rectangle r = new rectangle();
            r.calculateArea(3.2, 5.4);

        }
    }
}
