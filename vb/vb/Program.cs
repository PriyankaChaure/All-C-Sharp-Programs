using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dig, sum = 0, temp = 0, max=sum;
            for (int i = 0; i < 10; i++)
            {
             //dig = i;
               // sum += dig; 


                Console.WriteLine("enter no:");

                n = Convert.ToInt32(Console.ReadLine());

                while (n != 0)
                {
                    dig = n % 10;
                    sum = sum + dig;

                    n = n / 10;

                }
                Console.WriteLine("addition:"+sum);
                sum = temp;
                
            }

        }
    }
}
