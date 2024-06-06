using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_hiding
{
    class parent
    {
        public void p1Method()
        {
            Console.WriteLine("p1 method called!!!");
        }
        public void p2Method()
        {
            Console.WriteLine("p2 method called!!");
        }
    }
    class child:parent
    {
        public void childMethod()
        {
            Console.WriteLine("child method called!!");
        }
        public new void p1Method()
        {
            Console.WriteLine(" parent p1Method method called in child class using hiding method ");
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.p1Method();
            p.p2Method();
            child c = new child();
            c.p1Method();
            c.p2Method();
            c.childMethod();       

        }
    }
}
