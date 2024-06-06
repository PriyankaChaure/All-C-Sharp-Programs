using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = new int[3][];
            mat[0] = new int[2];
            mat[1] = new int[3];
            mat[2] = new int[1];
            mat[0][0] = 10;
            mat[0][1] = 5;
            mat[1][0] = 1;
            mat[1][1] = 7;
            mat[1][2] = 4;
            mat[2][0] = 3;
            Console.WriteLine(mat[0][0]);
            Console.WriteLine(mat[0][1]);
            Console.WriteLine(mat[1][0]);
            Console.WriteLine(mat[1][1]);
            Console.WriteLine(mat[1][2]);
            Console.WriteLine(mat[2][0]);


        }
    }
}
