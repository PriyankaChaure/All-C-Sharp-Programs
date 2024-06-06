using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n0 = 0, n1 = 1;
            int n2;
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            for (int i = 0; i < 15; i++)
            {
                n2 = n0 + n1;
                Console.WriteLine(n2);
                n0 = n1;
                n1 = n2;

            }
            Console.ReadLine();
        }
    }
}
