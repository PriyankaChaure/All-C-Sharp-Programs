using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_example
{
    class sample
    {
        
        public static int count=0;

        public sample()
        {
            if (count >= 1)
            {
                Console.WriteLine("can not create more than one object class is singleton 2nd object called");
            }
            count++;

        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            sample s1 = new sample();
            sample s2 = new sample();


        }
    }
}
