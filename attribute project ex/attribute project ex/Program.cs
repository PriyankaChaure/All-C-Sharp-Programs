using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attribute_project_ex
{
    class versionInfo:Attribute
    {
        private int VersionNo;
        private string devlopername;
        private string modulename;
        public  versionInfo(int vn,string dn,string mn)
        {
            VersionNo = vn;
            devlopername = dn;
            modulename = mn;
        }
    }
    [versionInfo(1,"prachi","abc")]
    class project
    {
        private int projectid;
        private string projectname;
        private string cityname;
        private decimal budget;
        [versionInfo(1, "prachi", "abc")]
        public void addpro(int pi,string pn,string cn,decimal b)
        {
            this.projectid=pi;
            this.projectname=pn;
            this.cityname=cn;
            this.budget=b;
        }
        public void dispro()
        {
            Console.WriteLine("project id:" + this.projectid);
            Console.WriteLine("project name:" + this.projectname);
            Console.WriteLine("city name:" + this.cityname);
            Console.WriteLine("project budjet:" + budget);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            project p = new project();
            p.addpro(1, "abc", "pune", 10000);
            p.dispro();
        }
    }
}
