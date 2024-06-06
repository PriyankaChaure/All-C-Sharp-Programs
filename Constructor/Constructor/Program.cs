using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class book
    {
        private int bookid;
        private string bookname;
        private string authername;
        private double price;

        public book(int bi,string bn)
        {
            this.bookid = bi;
            this.bookname = bn;
        }
        public book(int bi, string bn,string an)
        {
            this.bookid = bi;
            this.bookname = bn;
            this.authername = an;
        }
        public book(int bi, string bn, string an,double pr)
        {
            this.bookid = bi;
            this.bookname = bn;
            this.authername = an;
            this.price = pr;
        }


        public  void disbook()
        {
            Console.WriteLine("book id is:" + bookid);
            Console.WriteLine("book name is:" + bookname);
            Console.WriteLine("book auther name is:" + authername);
            Console.WriteLine("book price is:" + price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
             book b1= new book(1, "abc");
            b1.disbook();
            book b2 =new book (1, "abc","priya");
            b2.disbook();
            book b3 = new book(1, "abc","priya",1345);
            b3.disbook();
        }
    }
}
