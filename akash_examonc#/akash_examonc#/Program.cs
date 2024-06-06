using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akash_examonc_
{
    class  DataStore<T>
    {
        private string[] names = { "priyanka","prachi","sweety","guddi","sonali"};
        public void addElement(string[] n)
        {
            this.names = n;
        }
        public void removeElement(T r)
        {

        }
        public void displayAllElements()
        {
            Console.WriteLine(this.names);
        }
        public void insertElement(T i)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            DataStore<string> d = new DataStore<string>();
            d.displayAllElements();
        }
    }
}
