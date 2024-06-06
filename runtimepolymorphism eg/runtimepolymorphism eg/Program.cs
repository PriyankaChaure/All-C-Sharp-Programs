using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace runtimepolymorphism_eg
{
    class Device
    {
        public int deviceid;
        public string mfgname;
        
        public Device()
        {
            deviceid = 1 ;
            mfgname = "desktop";
        }
        public virtual void disdeviceinfo()
        {
            Console.WriteLine("device id is:" + deviceid);
            Console.WriteLine("device mfgname is:" +mfgname  );
        }
    }
    class Printer : Device
    {
        public int traycapacity;
        public double printerpersecond;
        public string printertype;

        public Printer()
        {
            traycapacity = 1000;
           printerpersecond = 2.4;
            printertype = "abc";
        }

        public override void disdeviceinfo()
        {    
            base.disdeviceinfo();
            Console.WriteLine("tray capacity is:" + this.traycapacity);
            Console.WriteLine("printer per second is:" + this.printerpersecond);
            Console.WriteLine("printer type is:" + this.printertype);
        }

       
    }
    class Monitor:Device
    {
        public int resolution;
        public string monitortype;

        public Monitor()
        {
            resolution = 23;
            monitortype = "standard";
        }

        public override void disdeviceinfo()
        {
            base.disdeviceinfo();
            Console.WriteLine(" monitor resolution is:" + this.resolution);
            Console.WriteLine(" monitor type is:" + this.monitortype);
        }

        
    }
     class Xerox : Device
    {
        public double noofpagespersecond;
        public string xeroxtype;

        public Xerox()
        {
            noofpagespersecond = 1;
           xeroxtype ="color" ;
        }

        
        public override void disdeviceinfo()
        {
            base.disdeviceinfo();
            Console.WriteLine(" no of pages per second is:" + this.noofpagespersecond);
            Console.WriteLine("xerox type is:" + this.xeroxtype);
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Device d = new Device();
            Console.WriteLine("enter 1 for printer details!!! ");
            Console.WriteLine("enter 2 for monitor details!!! ");
            Console.WriteLine("enter 3 for xerox details!!! ");
            Console.WriteLine("plz enter options:");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    d = new Printer();
                    break;
                case 2:
                    d = new Monitor();
                    break;
                case 3:
                    d = new Xerox();
                    break;
                 default:
                    Console.WriteLine("option are not present!!!!");
                    break;
            }
            
            d.disdeviceinfo();

            

        }
    }
}
