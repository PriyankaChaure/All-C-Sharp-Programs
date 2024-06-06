using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_modifier_or_keyword_ex
{
    internal partial class product
    {
        public void addproduct(int pi,string pn,string mfg,double pr)
        {
            this.productid = pi;
            this.productname = pn;
            this.mfgname = mfg;
            this.price = pr;

        }

        public void disproduct()
        {
            Console.WriteLine("product id:" + this.productid);
            Console.WriteLine("product name:" + this.productname);
            Console.WriteLine("product mfgname:" + this.mfgname);
            Console.WriteLine("product price:" + this.price);
        }
    }
}
