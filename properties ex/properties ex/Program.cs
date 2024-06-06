using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_ex
{
    class product
    {
        private int productid;
        private string productname;
        private string productmfgname;
        private double productprice;
        
        public double proprice
        {
            set
            {
                if (value > 0)
                {
                    productprice = value;
                }
                else
                {
                    Console.WriteLine("invalid price!!!");
                }
            }
            get
            {
                return productprice;
            }
        }
        public product(int pi,string pn,string pmfg,double pp)
        {
            this.productid = pi;
            this.productname = pn;
            this.productmfgname = pmfg;
            this.productprice = pp;
        }

        public void disproduct()
        {
            Console.WriteLine("product id is:" + this.productid);
            Console.WriteLine("product name is:" + this.productname);
            Console.WriteLine("product mfg name is:" + this.productmfgname);
            Console.WriteLine("product price is:" + this.productprice);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int pi;
            string pn;
            string pmfg;
            double pp;
           List< product> p = new List<product>();
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("enter product id:");
                pi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter product name:");
                pn = Console.ReadLine();

                Console.WriteLine("enter product mfg name:");
                pmfg = Console.ReadLine();

                Console.WriteLine("enter product price:");
                pp = Convert.ToDouble(Console.ReadLine());

                p.Add(new product(pi, pn, pmfg, pp));       //using constructor68

                //product temp = new product();
                //temp.addproduct(pi, pn, pmfg, pp);    //using method
                //p.Add(temp);
            }
            Console.WriteLine("...........output...........");
            foreach(product te in p)
            {
                if(te.proprice>10000 && te.proprice<20000)
                {
                    te.disproduct();
                }
            }
        }
    }
}
