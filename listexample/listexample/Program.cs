using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listexample
{
    class employee
    {
        private int employeeid;
        private string employeename;
        public string employeedepartment;
        private double employeesalary;

        public void addemp(int ei,string en,string ed, double es)
        {
            this.employeeid = ei;
           this.employeename = en;
            this.employeedepartment = ed;
            this.employeesalary = es;
        }

        public employee(int ei, string en, string ed, double es)
        {
            this.employeeid = ei;
            this.employeename = en;
            this.employeedepartment = ed;
            this.employeesalary = es;
        }

        public void disemp()
        {  
                Console.WriteLine("employee id is:" + employeeid);
                Console.WriteLine("employee name is:" + employeename);
                Console.WriteLine("employee department is:" + employeedepartment);
                Console.WriteLine("employee salary is:" + employeesalary);
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 

           List<employee> e = new List<employee>();
            int ei;
            string en;
            string ed;
            double ep;
            Console.WriteLine("enter users information.......");
            for ( int i=0;i<4; i++)
            {
               
                Console.WriteLine("enter employee id:");
                ei= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name:");
                en = Console.ReadLine();
                Console.WriteLine("enter employee department:");
                ed = Console.ReadLine();
                Console.WriteLine("enter employee salary:");
                ep= Convert.ToInt64(Console.ReadLine());

                //employee temp = new employee();      //this lines used when we do this with method
                //temp.addemp(ei, en, ed, ep);
                //e.Add(temp);


                e.Add(new employee(ei, en, ed, ep));     //this line is used when weused constructor

            }

            foreach(employee emp in e)
            {
                if (emp.employeedepartment == "computer")
                {
                    emp.disemp();
                }
            }
        }
    }
}
