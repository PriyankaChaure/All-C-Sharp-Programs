using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace search_no_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool find = false;
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter no:");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("enter number you want to search");
            int s = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < 10; i++)
            {
                if(s== n[i])
                {
                    
                    Console.WriteLine("no is present in array");
                    find = true;
                    break;
                }
                
             }
            if (!find)
            {

            
                Console.WriteLine("no is not present in array");
            }
            
            //Console.WriteLine("no is present in array");

        }
    }
}
