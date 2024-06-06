using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_universalc_stack//queue,arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("prachi");
            s.Push(123);
            s.Push(23.54);
            s.Push(12);
            s.Push(true);
            s.Push('a');
            Console.WriteLine("Stack===================>");
            Console.WriteLine( s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue('p');
            q.Enqueue("priyanka");
            q.Enqueue(1);
            q.Enqueue(123.65);
            q.Enqueue(145);
            q.Enqueue(false);
            Console.WriteLine("Queue===========>");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("c#");
            al.Add("vb");  
            al.Add(18.78);
            al.Add('d');
            al.Add(true);
            Console.WriteLine("Arraylist==========>");
            Console.WriteLine("original list............");
            //for (int i=0; i<al.Count;i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            foreach (object temp in al)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("after list........");

            al.Insert(3, "f#");
          // al.Remove("c#");
           // al.RemoveAt(5);
           // al.Clear();
            Console.WriteLine("Contains:" + al.Contains("f#"));
            Console.WriteLine("Count is:"+al.Count);
            foreach(object temp in al)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
