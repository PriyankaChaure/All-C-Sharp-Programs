using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter no");
                n = Convert.ToInt32(Console.ReadLine());
                if(n%2==0)
                {
                    cnt1++;
                }
                else if(n%2!=0)
                {
                    cnt2++;
                }
            }
            Console.WriteLine("even no count is:" + cnt1);
            Console.WriteLine("odd no count is:" + cnt2);
        }
    }
}
