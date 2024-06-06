using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_type_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = new object();
          
            o = "Priyanka, Prachi";      //Heap dat structure
            Console.WriteLine(o);
            o = 34;
            Console.WriteLine(o);
            o = 56.89;
            Console.WriteLine(o);
            o = true;
            Console.WriteLine(o);
            o = new DateTime();
            Console.WriteLine(DateTime.Now); //own statement created...
            int a = 10;   //stack data structure
            o = a;
            Console.WriteLine(o);
            int b = (int)o;   //unboxing explicite type casting
            Console.WriteLine(b);


        }
    }
}
