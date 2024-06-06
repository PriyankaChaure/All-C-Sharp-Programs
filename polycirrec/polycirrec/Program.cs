using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polycirrec
{  
    class shapes
    {
        public void calculatearea(double radius)
        {
            Console.WriteLine("area of circle is:" + (3.14 * radius * radius));
        }
        public void calculatearea(int length, int width)
        {
            Console.WriteLine("area of rectangle is:" + (length*width));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shapes s = new shapes();
            s.calculatearea(4.5);
            s.calculatearea(3, 4);
        }
    }
}
