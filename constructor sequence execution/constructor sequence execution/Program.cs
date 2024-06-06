using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_sequence_execution
{
    class parent
    {
        public parent()
        {
            Console.WriteLine("parent default constructor called!!!");
        }
        public parent(int a)
        {
            Console.WriteLine("parent with one parameter constructor called!!!");
        }
        public parent(int a, int b)
        {
            Console.WriteLine("parent with two parameter constructor callled!!!");
        }
    }
    class child : parent
    {
        public child():base(11) //base----> is used for execute 1 parameterize constructor from parent class
        { 
            Console.WriteLine("Child default Constructor called!!!");
        }
        public child(int n)   //default constructor called from parent class
        {
            Console.WriteLine("child with one parameter constructor callled!!!");
        }
        public child(int x,int y,int z):base(15,16)   //base----> is used for execute 2 parameterize constructor from parent class
        {
            Console.WriteLine("Child with three parameter constructor called!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            child c1 = new child(10);
            
            child c3 = new child(40, 50, 60);
        }
    }
}
