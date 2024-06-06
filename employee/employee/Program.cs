using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        internal class Employee
        {
            private int empid;
            private string empname;
            private string empdeptname;
            private int empsalary;

            public void AddEmployee()
            {
                Console.WriteLine("enter employee id:");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name:");
                empname = Console.ReadLine();
                Console.WriteLine("enter employee department:");
                empdeptname = Console.ReadLine();
                Console.WriteLine("enter employee salary:");
                empsalary = Convert.ToInt32(Console.ReadLine());
            }
            public void DisplayEmployee()
            {
                Console.WriteLine("emp id:" + empid);
                Console.WriteLine("emp name:" + empname);
                Console.WriteLine("emp dept name:" + empdeptname);
                Console.WriteLine("emp salary:" + empsalary);
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee();
            e.AddEmployee();
            e1.AddEmployee();
         
            e.DisplayEmployee();
            e1.DisplayEmployee();
            

        }
    }
}
