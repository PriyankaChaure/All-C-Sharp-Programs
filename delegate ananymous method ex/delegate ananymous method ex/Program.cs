using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_ananymous_method_ex
{
    delegate int  gdel(int a, int b);
    delegate void edel(int a);
    delegate bool check(int a);
    internal class Program
    {
        static void Main(string[] args)
        {
            gdel g = delegate (int a, int b)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            };
            int r = g(5, 9);
            Console.WriteLine("grater no is:" + r);

            edel e = delegate (int a)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(" number is even:"+a);
                }
                else
                {
                    Console.WriteLine("number is odd:"+a);
                }

            };
            e(45);

            check c = delegate (int a)
            {
                return (a > 9 && a < 100);
            };
            bool ch = c(50);
            Console.WriteLine("number is 2 digit:"+ch);
        }
    }
}
