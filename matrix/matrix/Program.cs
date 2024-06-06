using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("enter no");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("matrix original out put is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + mat[i,j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("transpose output is:");
            int[,] tmat = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tmat = mat;
                    Console.Write(" " + tmat[j,i] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

