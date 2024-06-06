using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namespace_clinicNm_ex;

namespace namespace_clinicNm_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d=new Doctor();
            d.addDoctor(1, "priya", "pune", "priya@123gmail.com", 1234567890);
            d.dispDoctor();

            patient p = new patient();
            p.addPatient(2, "chakuli", "shirgaon", "chakuli@123gmail.com", 1999999999);
            p.display();
        }
    }
}
