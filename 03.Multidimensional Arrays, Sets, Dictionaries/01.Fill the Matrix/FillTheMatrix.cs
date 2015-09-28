using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter a size of matrix:");
        int sizeOfMatrix = int.Parse(Console.ReadLine());
        int cols = sizeOfMatrix;
        int rows = sizeOfMatrix;
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.WriteLine("matrix[{0},{1}]",row , col);
                int elements = int.Parse(Console.ReadLine());
                matrix[row, col] = elements;
            }
        }
        PrintMatrix(matrix , sizeOfMatrix);


    }

    static void PrintMatrix(int[,] arr, int n)
    {
        for (int i = 0; i < Math.Sqrt(arr.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(arr.Length); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
        }
    }
}



