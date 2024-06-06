using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicite_interface
{
    interface Aint1
    {
        void sayhello();
    }
    interface Aint2
    {
        void sayhello();
    }
    class message:Aint1,Aint2
    {
        void Aint1.sayhello()
        {
            Console.WriteLine("welcome");
        }
        void Aint2.sayhello()
        {
            Console.WriteLine("home");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aint1 a = new message();
            a.sayhello();
            Aint2 b = new message();
            b.sayhello();
        }
    }
}
