using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_method_ex
{

    public static class Advance_string
    {
        public static void sayhello(this string obj)
        {
            Console.WriteLine("Hello  "+obj);
        }
            
    }
}
