
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dig;
            Console.Write("enter no:");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                dig = n % 10;
                if (dig % 2 != 0)
                {


                    Console.Write("0");
                }
                else
                    Console.Write(dig);
                n = n / 10;
            }
            while (n != 0);
           // Console.Write(n);
        }
    }
}
