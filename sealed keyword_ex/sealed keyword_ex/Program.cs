using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_keyword_ex
{
    sealed class sample
    {
        public void s1method()
        {
            Console.WriteLine("s1 method called!!!");
        }
        public void s2method()
        {
            Console.WriteLine("s2 method called!!!");
        }
    }
    class test
    {
        public void t1method()
        {
            Console.WriteLine("t1 method called!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.t1method();

            sample s = new sample();
            s.s1method();
            s.s2method();
        }
    }
}
