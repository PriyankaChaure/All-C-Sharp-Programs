using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prachi_exam_c_
{
    public class Product
    {
        private int productid;
        private string productname;
        private string productmfgname;
        private double productprice;
        public  DateTime mfgdate;
        public DateTime expdate;
        public void add(int pi,string pn,string mfgn,double p ,DateTime mfgd,DateTime expd)
        {
            this.productid = pi;
            this.productname = pn;
            this.productmfgname = mfgn;
            this.productprice = p;
            this.mfgdate = mfgd;
            this.expdate = expd;
        }
        public void dis()
        {
            Console.WriteLine("product id:" +productid );
            Console.WriteLine("product name:" +productname );
            Console.WriteLine("product mfg name:" +productmfgname );
            Console.WriteLine("product price:" +productprice );
            Console.WriteLine("product mfgdate:" +mfgdate );
            Console.WriteLine("product expdate:" +expdate );

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime();
            //string dt="2022-08-24";
            //var parse=DateTime.Parse(dt);

            //Console.WriteLine(parse);

            Product[] pro = new Product[10];
            int pi; string pn, mfgn;double p;DateTime  expd, mfgd;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter product id:");
                pi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product name:");
                pn = Console.ReadLine();
                Console.WriteLine("Enter product mfg name:");
                mfgn = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter product mfg date:");
                mfgd = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter product id:");
                expd = Convert.ToDateTime(Console.ReadLine());
                pro[i] = new Product();
                pro[i].add(pi, pn, mfgn, p, mfgd, expd);
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    pro[i].dis();
            //}
            foreach(Product value in pro)
            {
                value.dis();
            }

        }
    }
}
