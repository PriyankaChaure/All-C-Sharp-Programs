using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productname = "mouse";
            double price = 340.676;
            string mfgname = "intel";
            Console.WriteLine("we had purchased " + productname+"having manufactured by "+mfgname+"price "+price);
            Console.WriteLine($"we had purchased {productname} having price {price} manufactured by {mfgname}"); //$ used for giving data members in curly backets
            Console.WriteLine("contains:" + productname.Contains('s'));

            string first = "priyanka";
            string second = "hello";
            Console.WriteLine(string.Concat(first, second));

            string t = "     hello and welcome to\"RI-tech\"         ";
            Console.WriteLine("original:" + t);

            string t1 = @"c#\vb\f#\ q#";   //@ used for '\' instead of giving'\\' 
            Console.WriteLine(t1);

            Console.WriteLine("Trim:" + t.Trim());
            Console.WriteLine("Start Tim:" + t.TrimStart());
            Console.WriteLine("end trim:" + t.TrimEnd());

            Console.WriteLine("new word");

            string str = "this string is used for demo!!!";
            Console.WriteLine(str);
            Console.WriteLine("To upper:"+str.ToUpper());
            Console.WriteLine("To Lower:" + str.ToLower());
            Console.WriteLine("Length:" + str.Length);
            Console.WriteLine("Start with:" + str.StartsWith("th"));
            Console.WriteLine("Ent With:" + str.EndsWith("o!!!"));
            Console.WriteLine("Index of:" + str.IndexOf("e"));
            Console.WriteLine("Last Index of:" + str.LastIndexOf("i"));
            Console.WriteLine("Replace:" + str.Replace("is", "was"));
            Console.WriteLine("Sub string:" + str.Substring(10));
            Console.WriteLine("Sub string:" + str.Substring(10, 6));

            string s = "first-second#third-fourth-fifth-sixth";
            Console.WriteLine("orignal string:" + s);
            string[] result = s.Split('-', '#');
            foreach(string temp in result)
            {
                Console.WriteLine(temp);
            }
        }
    }

 



}

















