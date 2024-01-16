using System;
using System.Net.Http.Headers;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] triangle = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            triangle[row] = new int[row + 1];
            triangle[row][0] = 1;
            int cols = triangle[row].Length;
            triangle[row][cols - 1] = 1;
            for (int col = 1; col < cols - 1; col++)
            {
                triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }
        }

        for (int row = 0; row < rows; row++)
        {
            int cols = triangle[row].Length;
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{triangle[row][col]} ");
            }
            Console.WriteLine();
        }
    }
}