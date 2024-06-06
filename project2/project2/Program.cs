using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        public class Project1
        {
            public int projectid;
            public string projectname;
            public string cityname;
            public string projectdisc;
            public double projectbuget;
            public void addProject1(int proid, string proname, string cn, string prodisc, double buget)
            {
             this.projectid = proid;
            this.projectname=proname;
            this.cityname=cn;
            this.projectdisc = prodisc;
            this.projectbuget=buget;  
            }
            public void disProject1()
            {
                Console.WriteLine("project id:" + this.projectid);
                Console.WriteLine("project name:" + this.projectname);
                Console.WriteLine("city name:" + this.cityname);
                Console.WriteLine("project disc:" + this.projectdisc);
                Console.WriteLine("project buget:" + this.projectbuget);
            }
        }
        static void Main(string[] args)
        {
            Project1[] pro = new Project1[3];
            int proid;
            string proname, cn, prodisc;
            double buget;
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("enter project id:" );
                proid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter project name:");
                proname =Console.ReadLine();
                Console.WriteLine("enter city name:");
                cn = Console.ReadLine();
                Console.WriteLine("enter project disc:");
                prodisc = Console.ReadLine();
                Console.WriteLine("enter project buget:");
                buget = Convert.ToDouble(Console.ReadLine());
                pro[i] = new Project1();
                pro[i].addProject1(proid, proname, cn, prodisc, buget);
                
            }
            Console.WriteLine("display=======>");
            //cn = Console.ReadLine();
            //for (int i=0; i<3; i++)
            //{
            //    cn = Console.ReadLine();
            //    if (cn =="pune")
            //    {
            //        pro[i].disProject1();
            //    }
            //}
            
            for (int i = 0; i < 3; i++)
            {
                //cn = Console.ReadLine();

                if (pro[i].cityname == "pune") 
                {
                    pro[i].disProject1();
                }
            }
        }
    }
}
