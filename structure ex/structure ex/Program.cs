using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_ex
{
    struct point
    {
        private int x;
        private int y;

        public void addpoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void dispoint()
        {
            Console.WriteLine("X:" + this.x);
            Console.WriteLine("Y:" + this.y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            point p = new point();
            p.addpoint(23, 30);
            p.dispoint();
        }
    }
}
