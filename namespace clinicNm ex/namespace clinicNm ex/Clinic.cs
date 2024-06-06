using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_clinicNm_ex
{  
    internal class  Doctor
    {
        private int doctorid;
        private string doctorname;
        private string doctoraddress;
        private string doctoremailid;
        private int doctoremobilenumber;
        public void addDoctor(int di,string dn,string da,string de,int mn)
        {
            this.doctorid = di;
            this.doctorname= dn;
            this.doctoraddress= da;
            this.doctoremailid= de;
            this.doctoremobilenumber = mn;
        }
        public void dispDoctor()
        {
            Console.WriteLine("Doctor id:" + this.doctorid);
            Console.WriteLine("Doctor name:" + this.doctorname);
            Console.WriteLine("Doctor address:" + this.doctoraddress);
            Console.WriteLine("Doctor email id:" + this.doctoremailid);
            Console.WriteLine("Doctor mobile number:" + this.doctoremobilenumber);
        }
    }
    internal class patient
    {
        private int patientid;
        private string patientname;
        private string patientaddress;
        private string patientemailid;
        private int patientmobilenumber;
        public void addPatient(int pi,string pn,string pa,string ei,int pm)
        {
            this.patientid = pi;
            this.patientname = pn;
            this.patientaddress = pa;
            this.patientemailid = ei;
            this.patientmobilenumber = pm;
        }
        public void display()
        {
            Console.WriteLine("patient id:"+this.patientid);
            Console.WriteLine("patient name:"+this.patientname);
            Console.WriteLine("patient address:"+this.patientaddress);
            Console.WriteLine("patient email id:"+this.patientemailid);
            Console.WriteLine("patient mobile number:"+this.patientmobilenumber);
        }
    }
}
