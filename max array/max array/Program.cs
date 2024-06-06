using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int max;
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter no");
                n[i] = Convert.ToInt32(Console.ReadLine());

            }
            int min = n[0];
            for(int i=1;i<10;i++)
            {
                if (min > n[i])
                {
                    min = n[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
