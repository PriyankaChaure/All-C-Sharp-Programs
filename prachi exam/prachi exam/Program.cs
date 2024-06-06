using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prachi_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dig, sum = 0;
            int[] n = new int[10];
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("enter numbers:");
                    n[i] = Convert.ToInt32(Console.ReadLine());
                while (n[i] != 0)
                {
                    dig = n[i] % 10;
                    sum = sum + dig;
                    n[i] = n[i] / 10;
                    Console.WriteLine("addition:" + sum);
                }
                

            }
            for (int i = 0; i < 10; i++)
            {
            //    dig = n[i] % 10;
            //    sum = sum + dig;
            //    n[i] = n[i] / 10;
            //    Console.WriteLine("addition:" + sum);

            }
        }
    }
}
