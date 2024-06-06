using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priyanka_examonC_
{
    class product
    {
        private int productid;
        private string productname;
        public string mfgname;
        private decimal productprice;

        public void addproduct(int pi,string pn,string mn,decimal pr)
        {
            this.productid = pi;
            this.productname = pn;
            this.mfgname = mn;
            this.productprice = pr;
        }

        public void disproduct()
        {
            Console.WriteLine("product id:" + this.productid);
            Console.WriteLine("product name:" + this.productname);
            Console.WriteLine("product mfg name:" + this.mfgname);
            Console.WriteLine("product price:" + this.productprice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> p = new List<product>();
            Dictionary<string , int> value = new Dictionary<string, int>();
           
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter product id:");
                int pi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter product name:");
                string pn = Console.ReadLine();
                Console.WriteLine("enter product mfg name:");
                string mn = Console.ReadLine();
                Console.WriteLine("enter product price:");
                decimal pr = Convert.ToDecimal(Console.ReadLine());

                product temp = new product();
                temp.addproduct(pi, pn, mn, pr);
                p.Add(temp);
            }
            Console.WriteLine("==============OUTPUT==================");

           
            foreach (var mn in p)
            {

                if (value.ContainsKey(mn.mfgname))
                {

                    value[mn.mfgname]++;
                    Console.WriteLine("============" + mn.mfgname + "==========");
                }
                else
                {
                    value[mn.mfgname] = 1;
                    Console.WriteLine("============" + mn.mfgname + "==========");
                }


                mn.disproduct();

            }
            

            foreach(var pair in value)
            {
                Console.WriteLine("product manufacture by:" + pair.Key + "-------" + "total products:" + pair.Value);
                
            }

        }
    }
}
