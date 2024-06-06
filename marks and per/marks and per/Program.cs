using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marks_and_per
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, bio, maths, eng;
            double total, per;
            Console.WriteLine("enter physics marks");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemistry marks");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter biology marks");
            bio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter english marks");
            eng = Convert.ToInt32(Console.ReadLine());
            total = phy + chem + bio + maths + eng;
            Console.WriteLine("your total marks is:"+ total);
            per = total / 5;
            Console.WriteLine("your percentage is:" + per);
            if(per>=70)
            {
                Console.WriteLine("distinction");
            }
            else if(per>=60)
            {
                Console.WriteLine("1st class ");
            }
            else if (per >= 50)
            {
                Console.WriteLine("2nd class ");
            }
            else if (per >= 40)
            {
                Console.WriteLine("pass ");
            }
            else 
            {
                Console.WriteLine("failS ");
            }

        }
    }
}
