using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_ex
{
    delegate void tdel();
    delegate void adel(int a, int b);
    internal class sample
    {
        public void s1method()
        {
            Console.WriteLine("s1method called!!!");
        }
        public void addition(int a,int b)
        {
            Console.WriteLine("addition is:" + (a + b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            tdel t = new tdel(s.s1method);
            t();

            adel a = new adel(s.addition);
            a(4, 5);
        }
    }
}
