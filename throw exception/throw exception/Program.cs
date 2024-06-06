using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_exception
{    
    internal class priceex:Exception
    {
        private string msg;
        public priceex(string m)
        {
            msg = m;
        }
        public void disex()
        {
            Console.WriteLine("price exception occured!!!"+msg);
        }
    }
    internal class product
    {
        private int productid;
        private string productname;
        private string productmanufacturename;
        private int productprice;
        public void addproduct(int pi,string pn,string mfg,int pp)
        {
            if (pp <= 0)
            {
                throw new priceex("price should be > 0");
            }
            this.productid = pi;
            this.productname = pn;
            this.productmanufacturename = mfg;
            this.productprice = pp;
           
        }
        public void display()
        {
            Console.WriteLine("product id is:" + this.productid);
            Console.WriteLine("product name is:" + this.productname);
            Console.WriteLine("product manufacture name is:" + this.productmanufacturename);
            Console.WriteLine("product price is:" + this.productprice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            try
            {
                p.addproduct(1, "pencil", "natraj", 5);
                p.display();
            }
            catch( priceex ex )
            {
                ex.disex();
               
               
            }
        }
    }
}
