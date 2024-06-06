using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_slicing_eg
{
    class parent
    {
        private int x, y;
        public void p1Method()
        {
            Console.WriteLine("p1 method called");
        }
        public  virtual void p2Method()
        {
            Console.WriteLine("p2 method called");
        }
    }
    class child:parent
    {
        private int a, b;
        public void childMethod()
        {
            Console.WriteLine("child method called!!");
        }
        public override void p2Method()
        {
            base.p2Method();
            Console.WriteLine("p2 method called in a child class");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.p1Method();
            p.p2Method();
            child cd = new child();
            cd.p1Method();
            cd.p2Method();
            cd.childMethod();
            p = cd;
            p.p1Method();
            p.p2Method() ;

        }
    }
}
