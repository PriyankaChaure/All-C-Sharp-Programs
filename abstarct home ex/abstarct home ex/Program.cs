using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarct_home_ex
{  
    abstract class  shape
    {
        public abstract void calculatearea(int d, int l);
    }
    class circle : shape
    {
        public override void calculatearea( int d, int l)
        {
            Console.WriteLine("area of circle is:" + (3.14 * d * d));
        }
    }
    class rectangle :shape
    {
        public override void calculatearea(int d,int l)
        {
            Console.WriteLine("area of rectangle is:" + (d * l));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.calculatearea(3, 0);

            rectangle r = new rectangle();
            r.calculatearea(5, 4);
        }
    }
}
