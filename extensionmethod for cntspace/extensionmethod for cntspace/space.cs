using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod_for_cntspace
{
    public static class space
    {
        public static int cntspace(this string obj)
        {
            int count = 0;
            for (int i = 0; i < obj.Length; i++)
            {
                
                if (obj[i ]== ' ')
                
                    count++;
                
            }
            return count;
        }
        //public static int cntchar(this string obj)
        //{
        //    int count = 0;
        //    for (int i = 0; i < obj.Length; i++)
        //    {
        //        var v = obj.Replace(" ", "");
        //        count++;
        //    }
        //    return count;
        //}
        public static int cntchar(this string obj)
        {
            int count = 0;
            for (int i = 0; i < obj.Length; i++)
            {

                if (obj[i] != ' ')

                    count++;

            }
            return count;
        }


    }
}
