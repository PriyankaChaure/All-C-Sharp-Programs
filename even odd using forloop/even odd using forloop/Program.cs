using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_using_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int n, even = 0, odd = 0;
             for (int i = 0; i < 10; i = i + 1)
             {
                 Console.WriteLine(" enter numbers");
                 n = Convert.ToInt32(Console.ReadLine());

                 if (n % 2 == 0)
                 {
                     even = n;
                     //Console.WriteLine("number is even"+ even);
                 }
                 else
                 {
                     odd = n;
                     //Console.WriteLine("number is odd" + odd);
                 }
             }
             Console.WriteLine("number is even" + even);
             Console.WriteLine("number is odd" + odd);*/
            int n, e=0 , o=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("enter numbers");
                n = Convert.ToInt32(Console.ReadLine());
                // sum = sum + n;
                if (n % 2 == 0)
                {
                    e = e + n;
                    //Console.WriteLine("even no:" + e);
                }
                else
                {
                    o = o + n;
                    //Console.WriteLine("odd no:" + o);
                }
            }
                Console.WriteLine("even no:" + e);

                Console.WriteLine("odd no:" + o);
            }

        }

       
       
    }
    


