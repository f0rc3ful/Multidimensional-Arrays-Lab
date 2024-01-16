using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int[] metrics = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rowss = metrics[0];
        int colss = metrics[1];

        int[,] matrix = new int[rowss, colss];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = input[col];
            }
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int sum = int.MinValue;
        int[] ab = new int[2];
        int[] cd = new int[2];

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                int a = matrix[i, j]; // (0,0)
                int b = matrix[i, j + 1]; // (0,1)
                int c = matrix[i + 1, j]; // (1,0)
                int d = matrix[i + 1, j + 1]; // (1,1)
                int currentSum = a + b + c + d;
                if (currentSum > sum)
                {
                    sum = currentSum;
                    ab[0] = a;
                    ab[1] = b;
                    cd[0] = c;
                    cd[1] = d;
                }
            }
        }
        Console.WriteLine(string.Join(" ", ab));
        Console.WriteLine(string.Join(" ", cd));
        Console.WriteLine(sum);
    }
}