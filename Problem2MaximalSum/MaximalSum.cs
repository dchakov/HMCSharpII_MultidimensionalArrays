//Problem 2. Maximal sum• Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Copy data from enclosed text file M x N numbers");
        Console.WriteLine("Please, enter number N rows");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number M columns");
        int numberM = int.Parse(Console.ReadLine());

        if (numberN<3 || numberM<3)
        {
            Console.WriteLine("N or M must be greater or equal to 3");
            return; 
        }

        int[,] matrix = new int[numberN, numberM];

        Console.WriteLine("Please, enter {0} numbers",numberM*numberN);

        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < numberN-2; row++)
        {
            for (int col = 0; col < numberM-2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum=sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The best platform from above matrix is");
        for (int row = bestRow; row < bestRow+3; row++)
        {
            for (int col = bestCol; col < bestCol +3; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is {0}",bestSum);
    }
}