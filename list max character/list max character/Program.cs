using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_max_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string temp;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter names:");
                temp = Console.ReadLine();
                names.Add(temp);
            }
                string maxname ="";
                int maxlength = 0;
                foreach(string te in names)
                {
                    if(te.Length > maxlength)
                    {
                        maxlength = te.Length;
                        maxname = te;
                    }
                }
                Console.WriteLine("max name:" + maxname);
                Console.WriteLine("max length:" + maxlength);
            
        }
    }
}
