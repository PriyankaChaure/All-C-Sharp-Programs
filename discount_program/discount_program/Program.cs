using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discount_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            int price;
            int dis;
            int amt;
            int total;
            Console.WriteLine("enter quanty");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter price");
            price = Convert.ToInt32(Console.ReadLine());
            amt = quantity + price;
            Console.WriteLine(" your total amount is:" + amt);

            if (amt > 10000)
            {
                dis = (amt * 10) / 100;
                Console.WriteLine(" 10% discount is " + dis);
                total = amt - dis;
                Console.WriteLine("After discount your total Payment is: " + total);
            }
            else if (amt < 10000)
            {
                dis = (amt * 5) / 100;
                Console.WriteLine(" 5% discount is " + dis);
                total = amt - dis;
                Console.WriteLine("After discount your total Payment is: " + total);
            }
        } 
    }
}
