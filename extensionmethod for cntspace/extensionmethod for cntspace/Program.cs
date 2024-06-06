using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace extensionmethod_for_cntspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "extension method for count space ";
            Console.WriteLine("string is:" + s);
            s.cntspace();
            int r=s.cntspace();
    
            Console.WriteLine("count of space is:"+r);
            s.cntchar();
            int r1=s.cntchar();

            Console.WriteLine("count of character is:" + r1);
        }
    }
}
