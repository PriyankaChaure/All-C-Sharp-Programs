using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_ex
{
    
        enum cities
        {
            pune,mumbai=200,noida, delhi=300,pcmc
        }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)cities.pune);
            Console.WriteLine((int)cities.mumbai);
            Console.WriteLine((int)cities.noida);
            Console.WriteLine((int)cities.delhi);
            Console.WriteLine((int)cities.pcmc);
        }
    }
}
