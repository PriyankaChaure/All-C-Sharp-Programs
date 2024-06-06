using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_generictype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Priyanka");
            s.Push("Prachi");
            s.Push("Sweety");
            s.Push("Sonali");
            s.Push("Babli");
            Console.WriteLine("Stack ===================>");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Queue<int> q = new Queue<int>();
            q.Enqueue(23);
            q.Enqueue(24);
            q.Enqueue(25);
            q.Enqueue(26);
            q.Enqueue(27);
            Console.WriteLine("Queue================>");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            List<string> l = new List<string>();
            l.Add("mysql");
            l.Add("mongodb");
            l.Add("mariadb");
            l.Add("hadoop");
            l.Add("postgresql");
            Console.WriteLine("List================>");
            Console.WriteLine("original list.............");
            foreach(string temp in l)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("afte list.............");
            Console.WriteLine("Count is:" + l.Count);
            Console.WriteLine(l.Remove("mariadb"));
            Console.WriteLine("contains is :"+l.Contains("mysql"));
            // Console.WriteLine(l.Insert(3,"casentra"));
            //Console.WriteLine(l.RemoveAt(4));
            
            foreach (string t in l)
            {
                Console.WriteLine(t);
            }

            List <string> l1 = new List <string>();
            l1.Add("pqr");
            l1.Add("xyz");
            l1.Add("abc");
            l1.Add("wxy");
            l1.Add("hmt");

         //Console.WriteLine(l.AddRange(l1));
           //List<string>l.InsertRange(3,List<string>"btd");

        }
    }
}
