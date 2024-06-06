using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthday_wish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            int date;
            Console.WriteLine("enter birth month:");
            month=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter birth date:");
            date=Convert.ToInt32(Console.ReadLine());
            
            
            if(date==DateTime.Now.Day && month==DateTime.Now.Month)
            {
                Console.WriteLine("Todat it's Your Birthday");
                Console.WriteLine("Happy Birthday!!!");
            }
            else
            {
                Console.WriteLine("try again!!!");
            }
           
        }
    }
}
