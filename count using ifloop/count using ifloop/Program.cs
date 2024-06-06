using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_using_ifloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, count=0;
            for(int i = 0;i<10; i++)
                {
                Console.WriteLine("enter number");
                n = Convert.ToInt32(Console.ReadLine());
                if(n>9 && n<100)
                {
                    count++;
                }
               
            }
            Console.WriteLine("count is :" + count);
        }
    }
}
