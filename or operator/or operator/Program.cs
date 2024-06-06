using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zinc, copper;
            Console.WriteLine("enter zinc");
            zinc= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter copper");
            copper = Convert.ToInt32(Console.ReadLine());
            if(zinc>80 ||copper>90)
            {
                Console.WriteLine("good quality");

            }
            else
                Console.WriteLine("bad quality");


        }
    }
}
