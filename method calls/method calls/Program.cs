using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_calls
{
    class sample
    {
        public void change(int n)      //formal parameter,called point, function defination   //call by value
        {
            n = n + 100;
        }

        public void changeref(ref int a)    //call by reference
        {
            a = a + 500;
        }

        public void changebyout( int a, out int c)  //change by out
        {
            c = a * a * a;
        }

        public void defaultvalue(int a=10, int b=20, int c=30)   //default value parameter function
        {
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + c);
        }

        public void namepara(int i,string s,double d)      //name parameter function
        {
            Console.WriteLine("I:" + i);
            Console.WriteLine("S:" + s);
            Console.WriteLine("D:" + d);
        }

        public void anynumberargument(params int[] num)     //any number argument function
        {
            foreach (int temp in num)
            {
                Console.WriteLine(temp);
            }

        }

        public void anynoanytype( params object[] num)      //any number any type function
        {
            foreach (object temp in num)
            {
                Console.WriteLine(temp);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            int n = 10;
            s.change(n);
            Console.WriteLine(n);

            int b = 20;
            s.changeref(ref b);
            Console.WriteLine(b);

            int r;
            s.changebyout(n, out r);
            Console.WriteLine(r);

            s.defaultvalue();
            s.defaultvalue(25);
            s.defaultvalue(27,67);
            s.defaultvalue(45,90,65);

            s.namepara(s: "prachi", i: 34, d: 67.89);

            s.anynumberargument(546, 658, 658, 7658);
            s.anynumberargument(3443,657,4354,98,213,658,89,546,645,67,564,233,76);

            s.anynoanytype(1, "hello", true, 45.90, 45789);


        }
    }
}
