using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_ex1
{
    enum cities
    {
        pune=100,mumbai=200,delhi=300,noida=400
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int citycode;
            double amount, discount_amount = 0;

            Console.WriteLine("enter city code:");
            citycode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            switch(citycode)
            {
                case (int)cities.pune:
                    discount_amount = amount * ((double)10 / 100);
                    break;
                case (int)cities.mumbai:
                    discount_amount = amount * ((double)20 / 100);
                    break;
                case (int)cities.delhi:
                    discount_amount = amount * ((double)30 / 100);
                    break;
                case (int)cities.noida:
                    discount_amount = amount * ((double)40 / 100);
                    break;
                default:
                    Console.WriteLine("no discount...");
                    break;
            }
            Console.WriteLine("discount amount:" + discount_amount);
        }
    }
}
