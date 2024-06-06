using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter no");
                n[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < 10; i++)
                Console.WriteLine("series is"+n[i]);
        }
    }
}
