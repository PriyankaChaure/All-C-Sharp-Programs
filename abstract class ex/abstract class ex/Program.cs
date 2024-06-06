using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_ex
{
     abstract class sample
    {
        public void s1method()
        {
            Console.WriteLine("s1 method called!!!");
        }
        public void s2method()
        {
            Console.WriteLine("s2 method called!!!");
        }
        public void s3method()
        {
            Console.WriteLine("s3 method called!!!");
        }
    }
    class test : sample
    {
        public void t1method()
        {
            Console.WriteLine("t1 method called!!!");
        }
        public void t2method()
        {
            Console.WriteLine("t2 method called!!!");
        }
        public void t3method()
        {
            Console.WriteLine("t3 method called!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.s1method();  //abstract nethod called in child class
            t.s2method();  //abstract nethod called in child class
            t.s3method();  //abstract nethod called in child class

            t.t1method();
            t.t2method();
            t.t3method();

        }
    }
}
