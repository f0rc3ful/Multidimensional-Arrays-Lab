using System;

class Program
{
    static void Main(string[] args)
    {
        int[] metrics = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = metrics[0];
        int cols = metrics[1];
        int[,] matrix = new int[rows, cols];
        int sum = 0;
        for (int row = 0; row < rows; row++)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
                sum += matrix[row, col];
            }
        }
        Console.WriteLine(matrix.GetLength(0)); // rows
        Console.WriteLine(matrix.GetLength(1)); // cols
        Console.WriteLine(sum); // sum
    }
}