using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weight_operater_overloading
{
    class weight
    {
        private int kg;
        private int gm;
        public void setweight(int k, int g)
        {
            this.kg = k;
            this.gm = g;
        }
        public void disweight()
        {
            Console.WriteLine("KG:" + kg);
            Console.WriteLine("GM:" + gm);
        }
        public static weight operator + (weight x, weight y)
        {
            weight temp = new weight();
            int tempkg = 0;
            
            temp.gm = x.gm + y.gm;
            if(temp.gm>=1000)
            {
                tempkg = temp.gm / 1000;
                temp.gm = temp.gm % 1000;
            }
            temp.kg=x.kg + y.kg+tempkg;
            return temp;

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            weight w1 = new weight();
            w1.setweight(30, 700);
            w1.disweight();
            weight w2 = new weight();
            w2.setweight(40, 900);
            w2.disweight();
            weight w3 = new weight();
            w3 = w2 + w1;//weight.operator+(w1,w2)...
            w3.disweight();

        }
    }
}
