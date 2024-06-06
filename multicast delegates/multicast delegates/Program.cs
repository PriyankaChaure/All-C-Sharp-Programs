using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_delegates
{
    delegate void del(int a, int b);
    class cmath
    {
        public void addnum(int a, int b)
        {
            Console.WriteLine("addition is:" + (a + b));
        }
        public void subnum(int a, int b)
        {
            Console.WriteLine("substraction is:" + (a - b));
        }
        public void mulnum(int a, int b)
        {
            Console.WriteLine("multiplication is:" + (a * b));
        }
        public void divnum(int a, int b)
        {
            Console.WriteLine("division is:" + (a / b));
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            cmath c = new cmath();
            del d = new del(c.addnum);
            d += c.subnum;
            d += c.mulnum;
            d += c.divnum;
            d(20, 5);

            Console.WriteLine("After Remove........");
            d -= c.mulnum;
            d -= c.subnum;
            d(30,5);


        }
    }
}
