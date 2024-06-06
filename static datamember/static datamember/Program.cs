using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_datamember
{
    class data
        {
        private static int count = 0;
        public void incrementcount()
        {
            count++;
            Console.WriteLine("count is:" + count);
        }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            data d1 = new data();
            d1.incrementcount();
            data d2 = new data();
            d2.incrementcount();
            data d3 = new data();
            d3.incrementcount();
            data d4 = new data();
            d4.incrementcount();
            data d5 = new data();
            d5.incrementcount();
        }
    }
}
