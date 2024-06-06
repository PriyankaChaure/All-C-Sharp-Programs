using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("enter 1st value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 2nd value:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division is:" + c);
            }
            catch (DivideByZeroException dv)
            {
                Console.WriteLine("divided by zero exception occured!!!");
                Console.WriteLine("enter non-zero value...");
                Console.WriteLine(dv.ToString());
            }
            catch(FormatException fe)
            {
                Console.WriteLine("format exception occured!!!");
                Console.WriteLine("enter integer value");
                Console.WriteLine(fe.ToString());
            }
            finally
            {
                Console.WriteLine("final block executed!!!");
            }

        }
    }
}
