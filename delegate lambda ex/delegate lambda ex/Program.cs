using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_lambda_ex
{
    delegate int mdel(int a, int b);
    delegate int sdel(int a);
    delegate bool edel(int a);
    delegate int gdel(int a, int b, int c);
    delegate int xdel(int a, int b, int c, int d);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            mdel m = (a, b) => a * b;
            int r = m(2, 6);
            Console.WriteLine("multiplication is:" + r);

            sdel s = (a) => a * a;
            int r1 = s(5);
            Console.WriteLine("square of 5 is:" + r1);

            edel e = (a) => a % 2 == 0;
            bool r2 = e(42);
            Console.WriteLine("42 is even:" + r2 );

            mdel m1 = (a, b) => a > b ? a : b;//using ternary conditional operator
            int r3 = m1(45, 89);
            Console.WriteLine("greater no is:" + r3);

            gdel g = (a, b, c) => (a > b && a > c) ? (a) : ((b > c) ? (b) : (c));
            int r4 = g(10, 20, 30);
            Console.WriteLine("greater no is:" + r4);

            edel e1 = (a) => a > 9 && a < 100;
            bool r5 = e1(10);
            Console.WriteLine("number is 2 digit or not:" + r5);

          //  xdel x = (a, b, c, d) => (((a > b && a > c && a > d) && (b > a && b > c && b > d)) ? (a: b))();
          xdel x=(a,b,c,d)=>(a > b && a > c && a > d) ? (a) :(b > c && b > d) ? (b) : ((c > d) ? (c) : (d));
            int r6 = x(70, 60, 50, 40);
            Console.WriteLine(r6);

        }
    }
}
