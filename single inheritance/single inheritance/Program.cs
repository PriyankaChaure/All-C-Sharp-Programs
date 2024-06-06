using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance
{
    internal class bill
    {
        private int billno;
        private string billdate;
        private string customername;

        protected void addbilldetails(int bn,string bd,string cn)
        {
            this.billno = bn;
            this.billdate = bd;
            this.customername = cn;
        }

        protected void displaybill()
        {
            Console.WriteLine("bill no:" + this.billno);
            Console.WriteLine("bill date:" + this.billdate);
            Console.WriteLine("customer name:" + this.customername);
        }
    }
    internal class mobilebill : bill
    {
        private string mobileno;
        private int noofcalls;
        private int callperrate;
        
        public void addmobiledetails(int bn,string bd,string cn, string mn,int noc,int cpr) 
        {
            addbilldetails(bn, bd, cn);
            this.mobileno = mn;
            this.noofcalls = noc;
            this.callperrate = cpr;
        }
        public void displaymobilebill()
        { 
            displaybill();
            Console.WriteLine("mobile no:" + this.mobileno);
            Console.WriteLine("no of calls:" + this.noofcalls);
            Console.WriteLine("call per rate:" + this.callperrate);
            Console.WriteLine("total amount:" + (this.noofcalls * this.callperrate));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            mobilebill mb = new mobilebill();
            {
                mb.addmobiledetails(123,"24-aug-23","priyanka","98765432",100,2);
                mb.displaymobilebill();
            }
        }
    }
}
