using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_method
{
    class person
    {
        public static int id;
        public static string name;
        public static int age;

        public  void add(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;
        }
        public static void display()
        {
            person p = new person();
            p.add(1, "priya", 23);
         
            Console.WriteLine("person id:" + id);
            Console.WriteLine("person name:" + name);
            Console.WriteLine("person age" + age);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person.display();
        }
    }
}
