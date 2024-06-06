using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_with_polymorphism
{
    class mobilebill
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
        public void displaymobilebill()
        {
            Console.WriteLine("mobile no:"+this.mobileno);
            Console.WriteLine("no of calls:" + this.noofcalls);
            Console.WriteLine("rate per call:" + this.ratepercall);
        }


    }
    class msebill : mobilebill 
    {
        public int meterno; 
        public int noofunits;
        public int rateperunits;

        public void addmsebill(string mn, int noc, int rpc, int meter,int nou,int rpu)
        {
            addmobilebill(mn, noc, rpc);
            this.meterno = meter;
            this.noofunits = nou;
            this.rateperunits = rpu;
        }
        public void displaymsebill()
        {
            displaymobilebill();
            Console.WriteLine("meter no:"+this.meterno);
            Console.WriteLine("no of units:" + this.noofunits);
            Console.WriteLine("rate per units:" + this.rateperunits);
        }
    }
    class bill:msebill
    {
        public int billno;
        public string billdate;
        public string customername;

        bill(string mn, int noc, int rpc,int meter, int nou, int rpu,int bn,string bd,string cn) 
        {
            this.billno = bn;
            this.billdate = bd;
            this.customername = cn;
        }
        public void displaybill()
        {
            displaymsebill();
            Console.WriteLine("bill no:" + this.billno);
            Console.WriteLine("bill date:" + this.billdate);
            Console.WriteLine("customer name:" + this.customername);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bill b = new bill("56757454",100,2,10,500,7,456,"24-05-23","priyanka");
            b.displaybill();
        }
    }
}
