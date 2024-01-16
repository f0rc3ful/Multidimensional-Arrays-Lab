using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            string[] arrayFiller = Console.ReadLine().Split();
            matrix[i] = new int[arrayFiller.Length];
            for (int j = 0; j < arrayFiller.Length; j++)
            {
                matrix[i][j] = int.Parse(arrayFiller[j]);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] command = input.Split();
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int value = int.Parse(command[3]);
            if (row < 0 || row > matrix.Length - 1|| col < 0 || col > matrix[row].Length - 1)
            {
                Console.WriteLine("Invalid coordinates");
            }
            else if (command[0] == "Add")
            {
                matrix[row][col] += value;
            }
            else if (command[0] == "Subtract")
            {
                matrix[row][col] -= value;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}