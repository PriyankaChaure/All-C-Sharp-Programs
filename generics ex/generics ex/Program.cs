using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_ex
{
    class search<T>
    {
        public bool DoSearch(T[] str, T s)
        {
            bool flag = false;
            foreach (T temp in str)
            {
                if(temp.Equals(s))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            search<String> s = new search<String>();
            string[] names = { "Priyanka,", "Prachi", "Sweety", "Sonali", "Babli" };
            if (s.DoSearch(names, "Sweety"))
            {
                Console.WriteLine("name found!!");
            }
            else
            {
                Console.WriteLine("name not found!!");
            }

            search<int> t = new search<int>();
            int[] integer = { 23, 56, 89, 46, 12, 67 };
            if (t.DoSearch(integer, 45))
            {
                Console.WriteLine("Integer found!!");
            }
            else
            {
                Console.WriteLine("Integer not found!!");
            }
            

        }
    }
}
