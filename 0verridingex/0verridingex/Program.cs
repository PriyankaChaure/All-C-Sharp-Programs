using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0verridingex
{
    class parent
    {
        
        public void p1method()
        {
            Console.WriteLine("parent p1 method called!!!");
        }
        public virtual void p2method()
        {
            Console.WriteLine("parent p2 method called!!!");
        }
    }
    class child : parent
    {
        public void childmethod()
        {
            Console.WriteLine("child method called!!!");
        }
        public override void p2method()
        {   //enhancement
            //base.p2method();
            //Console.WriteLine("p2 method is override from parent class!!!");

            //new code(child)
            Console.WriteLine("fghryhty");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.childmethod();
            c.p1method();
            c.p2method();
        }
    }
}
