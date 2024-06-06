using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attribute_ex
{
    class Devinfo : Attribute
    {
        private string devname;
        private string modulename;

        public Devinfo(string devname, string modulename)
        {
            this.devname = devname;
            this.modulename = modulename;
        }
    }

        [Devinfo("priyanka", "CRM")]
    

    class emp
    {
        private int empid;
        private string empname;
        private string empdetname;
        private decimal empsalary;

        [Devinfo("priyanka","CRM")]

        public emp(int eid, string en, string ed,decimal es)
        {
            this.empid = eid;
            this.empname = en;
            this.empdetname = ed;
            this.empsalary = es;
        }

        public void disemp()
        {
            Console.WriteLine("emp id:" + this.empid);
            Console.WriteLine("emp name:" + this.empname);
            Console.WriteLine("emp dept name:" + this.empdetname);
            Console.WriteLine("emp salary:" + this.empsalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp(1, "prachi", "comp", 658886);
            e.disemp();
        }
    }
}
