using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("enter num");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("num1 is grater " + num1);
                }
                else
                {
                    Console.WriteLine("num3 is grater " + num3);
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("num2 is grater " + num2);
            }
            else
            {
                Console.WriteLine("num3 is grater " + num3);
            }
        }
    }
}
