using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_ananymous_method
{
    delegate void tdel();
    delegate int adel(int b, int c);
    internal class Program
    {
        static void Main(string[] args)
        {
            tdel t = delegate ()
            {
                Console.WriteLine("hello");
            };
            t();

            adel a = delegate (int b, int c)
            {
                return b + c;
            };
            int r = a(4, 5);
            Console.WriteLine("Addition is:" + r);

        }
    }
}
