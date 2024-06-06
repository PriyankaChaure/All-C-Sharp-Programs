using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter year");
                year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0)
                {
                    cnt1++;
                }
                else if (year % 4 != 0)
                {
                    cnt2++;
                }
            }
            Console.WriteLine("leap year count is:" + cnt1);
            Console.WriteLine("not leap year count is:" + cnt2);
        }
    }
    
}
