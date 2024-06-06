using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloading_pmeg
{
    class point
    {
        private int x;
        private int y;
        public void initpoint(int a,int b)
        { 
            this.x = a; 
            this.y = b; 
        }
        public void dispoint()
        {
            Console.WriteLine("X:" + this.x);
            Console.WriteLine("Y:" + this.y);

        }
        public static point operator++(point temp)
        {
            temp.x++;
            temp.y++;
            return temp;
        }
        public static point operator --(point temp)
        {
            temp.x--;
            temp.y--;
            return temp;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            point p = new point();
            p.initpoint(3, 4);
            p.dispoint();
            p++;
            p.dispoint();
            p--;
            p.dispoint();
            p++;
            p.dispoint();
            p--;
            p.dispoint();
        }
    }
}
