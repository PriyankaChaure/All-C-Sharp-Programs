using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_ex
{
    abstract class sample
    {
        public void s1method()
        {
            Console.WriteLine("s1 method called!!!");
        }
        public abstract void s2method();

        public abstract void s3method();
       
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
        public override void s2method()   //override abstract method here from parent class
        {
            Console.WriteLine("parent s2 method callled!!!");
        }
        public override void s3method()
        {
            Console.WriteLine("parent s3 method callled!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.s1method();
            t.s2method();
            t.s3method();

            t.t1method();
            t.t2method();
            t.t3method();
        }
    }
}
