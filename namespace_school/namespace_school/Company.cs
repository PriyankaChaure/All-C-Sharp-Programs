using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_ex
{
    internal class Company
    {
        private int companyid;
        private string companyname;
        private string companyaddress;
        private string companyemailid;
        private int companymobilenumber;
        public void addCompany(int si, string sn, string sa, string se, int sm)
        {
            this.companyid = si;
            this.companyname = sn;
            this.companyaddress = sa;
            this.companyemailid = se;
            this.companymobilenumber = sm;

        }
        public void display()
        {
            Console.WriteLine(" company id:" + this.companyid);
            Console.WriteLine(" company name:" + this.companyname);
            Console.WriteLine(" company address:" + this.companyaddress);
            Console.WriteLine(" company email id:" + this.companyemailid);
            Console.WriteLine("company mobile number:" + this.companymobilenumber);
        }
    }
    internal class Department
    {
        private int deptid;
        private string deptname;
        public void addDept(int di, string dn)
        {
            this.deptid = di;
            this.deptname = dn;
        }
        public void dispdept()
        {
            Console.WriteLine("dept id:" + this.deptid);
            Console.WriteLine("dept name:" + this.deptname);
        }
    }
}
