using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dig, sum=0,temp=0,max=0;
            int[] n = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter numbers:");
                n[i] = Convert.ToInt32(Console.ReadLine());
                while (n[i] != 0)
                {
                    dig = n[i] % 10;
                    sum = sum + dig;
                    n[i] = n[i] / 10;
                      
                }
                Console.WriteLine("addition of no is:"+sum);
               // sum = temp;
                if (max< sum)
                {
                    max = sum;  
                }
                sum = temp;


            }
            Console.WriteLine("maximum no of sum is:"+max);

        }
    }
}
