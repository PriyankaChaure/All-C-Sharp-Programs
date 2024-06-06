using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_multipletypesymbol
{
    class sample<A,B,C,D>
    {
        public void display(A a,B b,C c,D d)
        {
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            Console.WriteLine("C: " + c);
            Console.WriteLine("D: " + d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample<string,int,double,bool>s=new sample<string,int,double,bool>();
            s.display("priyanka", 123, 345.987, true);
        }
    }
}
