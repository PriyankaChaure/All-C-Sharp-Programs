using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_datamember_ex1
{
    class person
    {
        private static int personage;
        private static string personname;
         static person()
        {
            personname = "prachi";
            personage = 21;
        }
        public void dis1(int a, string p)
        {
            personname = p;
            personage = a;


        }
        public void display()
        {
            Console.WriteLine("personname:" + personname);
            Console.WriteLine("perrsonage:" + personage);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.display();
            p.dis1(23, "priyanka");
            p.display();
        }
    }
}
