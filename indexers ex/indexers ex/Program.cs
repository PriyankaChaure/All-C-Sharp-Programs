using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers_ex
{
    class sample
    {
        private int[] data;

        public sample()   //constructor
        {
            this.data = new int[10];
        }
        public int this[int i]   //indexers method creation
        {
            set
            {
                data[i] = value;
            }
            get
            {
                return data[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s[0] = 56;
            s[1] = 36;
            s[2] = 26;
            s[3] = 16;
            s[4] = 86;
            s[5] = 96;
            s[6] = 46;
            s[7] = 76;
            s[8] = 54;
            s[9] = 23;
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);
            Console.WriteLine(s[3]);
            Console.WriteLine(s[4]);
            Console.WriteLine(s[5]);
            Console.WriteLine(s[6]);
            Console.WriteLine(s[7]);
            Console.WriteLine(s[8]);
            Console.WriteLine(s[9]);

        }
    }
}
