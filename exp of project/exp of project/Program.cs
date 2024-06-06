using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
 {
        internal class Program
        {
            internal class Project
            {
                private int proid;
                private string proname;
                public string cityname;
                private string prodisc;
                private double probudget;


                public void AddProject()
                {
                    Console.WriteLine("enter project id:");
                    proid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter project name:");
                    proname = Console.ReadLine();
                    Console.WriteLine("enter city name:");
                    cityname = Console.ReadLine();
                    Console.WriteLine("enter project discription:");
                    prodisc = Console.ReadLine();
                    Console.WriteLine("enter project budget:");
                    probudget = Convert.ToDouble(Console.ReadLine());
                }
                public void DisplayProject()
                {
                    Console.WriteLine("project id:" + proid);
                    Console.WriteLine("project name:" + proname);
                    Console.WriteLine("city name:" + cityname);
                    Console.WriteLine("project description:" + prodisc);
                    Console.WriteLine("project budget:" + probudget);
                }
            }
            static void Main(string[] args)
            {
            //string cityname;
               
                Project[] p = new Project[8];
                
                for (int i = 0; i < 2; i++)
                {
                    p[i] = new Project();
                    p[i].AddProject();
                    
                }

                cityname = Console.ReadLine();
                for (int i = 0; i < 2; i++)
                {
                    if (cityname == "pune") 
                    {
                        p[i].DisplayProject();
                    }
                }


            }
        }
    

}
    

