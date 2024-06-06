using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_search
{ internal class search
    {

      public bool dosearch(string[] str, string s)
        {
            bool flag = false;
            foreach(string temp in str)
            {
                if(temp==s)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool dosearch(int[] num, int n)
        {
            bool flag = false;
            foreach (int temp in num)
            {
                if (temp == n)
                {
                    flag = true;
                }
            }
            return flag;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            search se = new search();
            string[] s = { "abc", "pqr", "xyz", "lmp" };
            if(se.dosearch(s,"lmp"))
            {
                Console.WriteLine("String is found!!");
            }
            else
            {
                Console.WriteLine("String not found!!");
            }

            int[] num = { 123,456,789,147 };
            if (se.dosearch(num, 147))
            {
                Console.WriteLine("Integer is found!!");
            }
            else
            {
                Console.WriteLine("Integer not found!!");
            }

        }
    }
}
