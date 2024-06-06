using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_modifier_or_keyword_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            p.addproduct(1, "computer", "dell", 2345.7);
            p.disproduct();
        }
    }
}
