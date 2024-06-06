using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_with_polymorphism
{
    public class mobilebill
    {
        public string mobileno;
        public int noofcalls;
        public int ratepercall;

        public void addmobilebill(string mn, int noc, int rpc)
        {
            this.mobileno = mn;
            this.noofcalls = noc;
            this.ratepercall = rpc;
        }
        public void disbill()
        {
            Console.WriteLine("mobile no:" + this.mobileno);
            Console.WriteLine("no of calls:" + this.noofcalls);
            Console.WriteLine("rate per call:" + this.ratepercall);
        }


    }
    public class msebill
    {
        public int meterno;
        public int noofunits;
        public int rateperunits;

        public void addmsebill(int meter, int nou, int rpu)
        {
            
            this.meterno = meter;
            this.noofunits = nou;
            this.rateperunits = rpu;
        }
        public void disbill()
        {
            
            Console.WriteLine("meter no:" + this.meterno);
            Console.WriteLine("no of units:" + this.noofunits);
            Console.WriteLine("rate per units:" + this.rateperunits);
        }
    }
    public class bill 
    {
        public int billno;
        public string billdate;
        public string customername;

        public bill( int bn, string bd, string cn)
        {
            
            this.billno = bn;
            this.billdate = bd;
            this.customername = cn;
        }

        public void disbill()
        {
            mobilebill mb = new mobilebill();
            mb.addmobilebill("6798", 977, 4);
            mb.disbill();
            msebill msb = new msebill();
            msb.addmsebill(2, 100, 5);
            msb.disbill();
            //disbill();
            //disbill();
            Console.WriteLine("bill no:" + this.billno);
            Console.WriteLine("bill date:" + this.billdate);
            Console.WriteLine("customer name:" + this.customername);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bill b = new bill(90, "24-5-23", "priya");
            b.disbill();
            
            


            
           
        }
    }
}

