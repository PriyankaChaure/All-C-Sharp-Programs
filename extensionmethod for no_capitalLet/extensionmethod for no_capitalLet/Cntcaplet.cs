using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod_for_no_capitalLet
{
    public static class Cntcaplet
    {
        public static int cntletter(this string obj)
        {
            int count = 0;  
            for (int i = 0;i<obj.Length;i++)
            {
                if (obj[i] >= 'A' && obj[i] <='Z')
                    count++;
            }
            return count;
        }
    }
}
