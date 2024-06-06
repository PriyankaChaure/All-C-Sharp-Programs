using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("enter number");
                n = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(n+"+");
                sum = sum + n;
            }
            //Console.Write(sum + "+");
            Console.WriteLine("addition is: " + sum);
        }
    }
}
