using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        for (int row = 0; row < n; row++)
        {
            char[] input = Console.ReadLine().ToCharArray();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        char wanted = char.Parse(Console.ReadLine());
        bool found = false;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row, col] == wanted)
                {
                    Console.WriteLine($"({row}, {col})");
                    found = true;
                }
            }
            if (found)
            {
                break;
            }
        }
        if (!(found))
        {
            Console.WriteLine($"{wanted} does not occur in the matrix");
        }

    }
}