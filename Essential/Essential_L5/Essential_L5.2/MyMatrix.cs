using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._2
{
    class MyMatrix
    {
        int[,] matrix;
        private Random r = new Random();

        public MyMatrix(uint a, uint b)
        {
            matrix = new int[a, b];            
            Fill();
        }

        private void Fill()
        { 
            for (var i = 0; i < matrix.GetLength(0); i++)
			{
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(10, 99);
                }			 
			}
        }

        public void ShowMatrix()
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public int[,] ChangeMatrix(uint a, uint b)
        {
            int[,] newMatrix = new int [a, b];

            for (var i = 0; i < Math.Min(newMatrix.GetLength(0), matrix.GetLength(0)); i++)
            {
                for (var j = 0; j < Math.Min(newMatrix.GetLength(1), matrix.GetLength(1)); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
                if (b > matrix.GetLength(1))
                {
                    for (var j = matrix.GetLength(1); j < newMatrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = r.Next(10, 99);
                    }
                }                
            }
            if (a > matrix.GetLength(0))
            {
                for (var i = matrix.GetLength(0); i < newMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < newMatrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = r.Next(10, 99);
                    }
                }
            }
            if (a == 0 || b == 0)
            {
                Console.WriteLine("The number of rows and columns of the matrix should be more than zero");
            }
            return newMatrix;            
        }

    }
}
