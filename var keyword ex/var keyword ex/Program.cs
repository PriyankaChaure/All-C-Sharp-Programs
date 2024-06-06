using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_keyword_ex
{
    public class point
    {
        public int X { get; set; }
       public int Y { get; set; }
        public void dispoint()
        {
            Console.WriteLine("X: " + this.X);
            Console.WriteLine("Y: " + this.Y);

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var p = new point() { X = 10, Y = 30 };   //var point type
            p.dispoint();



            var v = "hello";           //var string type
            Console.WriteLine(v);

            var n = 100;            //var int type
            Console.WriteLine(n);
            int r = n + 200;
            Console.WriteLine(r);

            var e = new { empid=1,name="prachi",empdept="computer",sal=10000}; //var ananymous type
            Console.WriteLine("emp id:" + e.empid);
            Console.WriteLine("emp name:" + e.name);
            Console.WriteLine("emp dept:" + e.empdept);
            Console.WriteLine("emp salary:" + e.sal);

            var p1 = new { X = 12, Y = 15 }; // var ananymous type
            Console.WriteLine("X: " + p1.X);
            Console.WriteLine("Y: " + p1.Y);
        }
    }
}
