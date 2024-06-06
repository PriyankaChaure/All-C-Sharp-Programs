using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    class counter
    {
        private static int count;
        static counter()
        {
            count = 0;
        }
        public static void Increment()
        {
            count++;
            Console.WriteLine("count is:" + count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            counter.Increment();
            counter.Increment();
            counter.Increment(); 
            counter.Increment();
        }
    }
}
