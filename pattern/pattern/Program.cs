using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for(int k=1; k<=4; k++)
            {
                for (int j = k; j <= 4; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
