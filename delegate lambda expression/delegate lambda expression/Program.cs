using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_lambda_expression
{
    delegate int cdel(int a);
    delegate int tdel(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {// ananymous
            //cdel c = delegate (int n)
            //{
            //    return n * n * n;
            //};
            //int r = c(10);
            //Console.WriteLine("cube of 10 is:" + r);
            cdel c = (a) => a * a * a;
            int r = c(10);
            Console.WriteLine("cube of 10 is:"+r);

            tdel t = (a, b) => a + b;
            int re = t(100, 200);
            Console.WriteLine("addition is:" + re);
        }
    }
}
