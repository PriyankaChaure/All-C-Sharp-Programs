using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=4, m=5;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=m;j++)
                {
                    if (i == 1 || j == 1 || i == n || j == m)
                    {
                        Console.Write("*");
                    }
                    else 
                    { 
                        Console.WriteLine("  ");
                    }
                }
                //Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
