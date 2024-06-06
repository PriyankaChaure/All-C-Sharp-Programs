using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace short_syntax_and_dynamic_initialisation_ex
{
    class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mfgname { get; set; }
        public decimal price{ get; set; }
        public void disProduct()
        {
            Console.WriteLine("product id :" + this.id);
            Console.WriteLine("product name :" + this.name);
            Console.WriteLine("product mfgname :" + this.mfgname );
            Console.WriteLine("product price :" + this.price );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product { id = 1, name = "Processor", mfgname = "intel", price = 5000 };
            p.disProduct();
        }
    }
}
