//Problem 3. Sequence n matrix• We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//• Write a program that finds the longest sequence of equal strings in the matrix.
//Example:
//matrix
//ha fifi ho hi 
//fo ha hi xx 
//xxx ho ha xx 
//result ha, ha, ha  
//s qq s 
//pp pp s 
//pp qq s 
//result s, s, s

using System;

class SequenceNmatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number N rows");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number M columns");
        int numberM = int.Parse(Console.ReadLine());

        string[,] matrix = new string[numberN, numberM];

        Console.WriteLine("Please, enter {0} strings", numberM * numberN);

        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        int maxCounter = 0;
        int counter = 1;
        string longestSequence = "";


        // Check every single row

        for (int row = 0; row < numberN; row++)
        {
            for (int col = 1; col < numberM; col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }
        // Check every single column

        counter = 1;

        for (int col = 0; col < numberM; col++)
        {
            for (int row = 1; row < numberN; row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }

        // Check diagonals for every single element left to right

        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                counter = 1;
                for (int i = row, j = col; i < (numberN - 1) && (j < numberM - 1); i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
                }
            }

        }
        // Check diagonals for every single element right to left

        for (int row = 0; row < numberN; row++)
        {
            for (int col = numberM-1; col >= 0; col--)
            {
                counter = 1;
                for (int i = row, j = col; i < (numberN - 1) && (j > 0); i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
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
        Console.WriteLine();


        if (maxCounter > 1)
        {
            Console.Write(longestSequence);
            for (int i = 1; i < maxCounter; i++)
            {
                Console.Write("," + longestSequence);
            }
            Console.WriteLine();
        }
    }
}

