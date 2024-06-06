using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    static class calculation
    {
        private static int a;
        private static int b;

        static calculation()
        {
            a = 0;
            b = 0;
        }
        public static void addition(int x,int y)
        {
            a = x;
            b = y;
            Console.WriteLine(a + b);
        }
        public static void substraction(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine(a - b);
        }
        public static void multiplication(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine(a * b);
        }
        public static void division(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine(a / b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculation.addition(3, 4);
            calculation.substraction(9, 4);
            calculation.multiplication(6, 4);
            calculation.division(12, 4);

        }
    }
}
