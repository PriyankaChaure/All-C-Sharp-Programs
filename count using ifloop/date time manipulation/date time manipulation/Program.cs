using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            DateTime dt1 = new DateTime(2012, 11, 23, 12, 32, 45);
            Console.WriteLine(dt1);
            Console.WriteLine("Now:" + DateTime.Now);
            Console.WriteLine("days in month:" + DateTime.DaysInMonth(2012, 2));
            Console.WriteLine("Leap year:" + DateTime.IsLeapYear(2012));

            dt=DateTime.Now;
            Console.WriteLine(dt.AddDays(100));
            Console.WriteLine(dt.AddMonths(2));
            Console.WriteLine(dt.AddHours(5));
            Console.WriteLine(dt.AddMinutes(60));
            Console.WriteLine(dt.AddSeconds(120));

            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Second);

            dt = DateTime.Now.AddDays(5);        //return 1
            dt1 = DateTime.Now;
            Console.WriteLine(dt.CompareTo(dt1));

            dt = DateTime.Now;                //return 0
            dt1 = DateTime.Now;
            Console.WriteLine(dt.CompareTo(dt1));

            dt = DateTime.Now;                //return -1
            dt1 = DateTime.Now.AddDays(8);
            Console.WriteLine(dt.CompareTo(dt1));

            TimeSpan ts = dt.Subtract(dt1);
            Console.WriteLine("Substract:"+ts.TotalDays);

            Console.WriteLine("short date:" + dt.ToShortDateString());
            Console.WriteLine("Long date:" + dt.ToLongDateString());
            Console.WriteLine("short time:" + dt.ToShortTimeString());
            Console.WriteLine("Long time:" + dt.ToLongTimeString());
        }
    }
}
