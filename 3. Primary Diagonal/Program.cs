﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int sum = 0;
        for (int row = 0; row < n; row++)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = input[col];
            }
            sum += matrix[row, row];
        }
        Console.WriteLine(sum);
    }
}