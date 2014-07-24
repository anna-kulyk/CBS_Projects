using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._2
{
    class Program
    {
        static void ShowNewMatrix(int[,] mx)
        {
            for (var i = 0; i < mx.GetLength(0); i++)
            {
                for (var j = 0; j < mx.GetLength(1); j++)
                {
                    Console.Write(mx[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var matrix = new MyMatrix(2, 3);
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 30));
            int[,] matrix1 = matrix.ChangeMatrix(3, 4);
            ShowNewMatrix(matrix1);
            Console.WriteLine(new string('-', 30));
            int[,] matrix2 = matrix.ChangeMatrix(1, 4);
            ShowNewMatrix(matrix2);
            Console.WriteLine(new string('-', 30));
            int[,] matrix3 = matrix.ChangeMatrix(5, 2);
            ShowNewMatrix(matrix3);
            Console.WriteLine(new string('-', 30));
            int[,] matrix4 = matrix.ChangeMatrix(0, 5);
            ShowNewMatrix(matrix4);
        }
    }
}
