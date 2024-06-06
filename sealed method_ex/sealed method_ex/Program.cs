using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method_ex
{
    class A
    {
        public virtual void create()
        {
            Console.WriteLine("A created");
        }
    }
    class B:A
    {
        public sealed override void create()
        {
            Console.WriteLine("B created");
        }
    }
    class C : B
    {
       // public  override void create()
        //{
          //  Console.WriteLine("C created");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //C c = new C();
            //c.create();

            B b = new B();
                b.create();



        }
    }
}
