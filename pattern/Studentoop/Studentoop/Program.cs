using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentoop
{
    internal class Program
    {
        internal class Student1
        {
            private int RollNo;
            private string Name;
            private string MobileNo;
            private string CourseName;

            public void AddStudent(int rn,string n,string mn,string cn)
            {
                RollNo = rn;
                Name = n;
                MobileNo = mn;
                CourseName = cn;
            }
            public void DisplayStudent()
            {
                Console.WriteLine("RollNo:" + RollNo);
                Console.WriteLine("name:" + Name);
                Console.WriteLine("Mobile no:" + MobileNo);
                Console.WriteLine("Course Name:" + CourseName);
            }

        }
  
        static void Main(string[] args)
        {
            Student1 s = new Student1();
            s.AddStudent(1, "priya", "12345", "c#");
            s.DisplayStudent();

        }
    }
}
