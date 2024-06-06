using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter email id:");
            string s = Console.ReadLine();
            string[] result = s.Split('@', '.');
            Console.WriteLine("email id:" + result[0]);
            Console.WriteLine("domain:" + result[1]);
            Console.WriteLine("extension:" + result[2]);



            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            for (int i = 0; i <= name.Length; i++)
            {
                Console.WriteLine(name.Substring(0, i));
            }

           // name reverse is pending.........

            //Console.WriteLine("enter name:");
            //string name1 = Console.ReadLine();


            //for (int i = 0; i <= name1.Length; i++)

            //{
            //    Console.WriteLine(name1.Substring(i, 0));

            //  }
            //string name;
            //Console.WriteLine("enter name:");
            //name = Console.ReadLine();
            //for (int i = 0;i <10; i++);
        }
    }
}
