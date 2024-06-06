using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod_for_no_capitalLet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Prachi Priyanka";
            int r = s.cntletter();
            Console.WriteLine ("count of capital letters is:"+r);
        }
    }
}
