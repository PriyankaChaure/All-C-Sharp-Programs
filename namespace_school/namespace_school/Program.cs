using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school_ex;
using Company_ex;

namespace namespace_school
{
    internal class Program
    {
        static void Main(string[] args)
        { 
             school s=new  school();
            s.addSchool(1, "sspms", "rto", "sspm@123gmail.com", 456789909);
            s.display();
           school_ex.Department d = new school_ex.Department();//in a namespace having same classes then we have to give full namespace name
            d.addDept(2, "library");
            d.dispdept();

            Company c = new Company();
            c.addCompany(3, "plastic", "kamshet", "plastic@gmail.com", 46546757);
            c.display();
            Company_ex.Department d1 = new Company_ex.Department();
            d1.addDept(4, "bottol");
            d1.dispdept();


        }
    }
}
