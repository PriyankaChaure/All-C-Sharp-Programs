using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age; String gender;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter gender");
            gender = Console.ReadLine();
            if(age>18 && gender=="female")
            {
                Console.WriteLine("qualified for job");
            }
            else
                Console.WriteLine("not qualified for job");
        }
    }
}
