using System;

class Program
{
    static void Main(string[] args)
    {
        int[] specs = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = specs[0];
        int cols = specs[1];
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();    
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        int matrixRows = matrix.GetLength(0);
        int matrixCols = matrix.GetLength(1);

        for (int col = 0; col < matrixCols; col++)
        {
            int sum = 0;
            for (int row = 0; row < matrixRows; row++)
            { 
            sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }
    }
}