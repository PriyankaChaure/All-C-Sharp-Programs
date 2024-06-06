using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface AreaInt
{
    void calculateArea(double r);
    
}
class circle : AreaInt
{
    public void calculateArea(double r)
    {
        Console.WriteLine("Area of circle is:"+(3.14*r* r));
    }
}
namespace interface_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.calculateArea(4.2);
            
        }
    }
}
