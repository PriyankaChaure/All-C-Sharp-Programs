using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
