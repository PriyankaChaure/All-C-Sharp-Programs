using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_ex
{
    internal class school
    {
        private int schoolid;
        private string schoolname;
        private string schooladdress;
        private string schoolemailid;
        private int schoolmobilenumber;
        public void addSchool(int si,string sn,string sa,string se,int sm)
        {
            this.schoolid= si;  
            this.schoolname= sn;
            this.schooladdress= sa;
            this.schoolemailid= se;
            this.schoolmobilenumber = sm;

        }
        public void display()
        {
            Console.WriteLine("school id:"+this.schoolid);
            Console.WriteLine("school name:" + this.schoolname);
            Console.WriteLine("school address:" + this.schooladdress);
            Console.WriteLine("school email id:" + this.schoolemailid);
            Console.WriteLine("school mobile number:" + this.schoolmobilenumber);
        }
    }
    internal class Department
    {
        private int deptid;
        private string deptname;
        public void addDept(int di,string dn)
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
