//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//a)  1	5	9	13   
//    2	6	10	14   
//    3	7	11	15   
//    4	8	12	16   

//b)  1	8	9	16
//    2	7	10	15
//    3	6	11	14
//    4	5	12	13	

//c)  7	11	14	16
//    4	8	12	15
//    2	5	9	13
//    1	3	6	10

//d)* 1	12	11	10
//    2	13	16	9
//    3	14	15	8
//    4	5	6	7

using System;
using System.Diagnostics;
using System.Threading;

class Fillthematrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number N");
        int numN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[numN, numN];

        // A) 
        Stopwatch stopwatch = Stopwatch.StartNew();

        Console.WriteLine("a1) code 1 A problem");
        int tempA = 1;
        for (int row = 0; row < numN; row++)
        {
            for (int col = 0; col < numN; col++)
            {
                matrix[row, col] = tempA;
                tempA += numN;
                Console.Write("{0,3}", matrix[row, col]);
            }
            tempA = row + 2;
            Console.WriteLine();
        }
        System.Threading.Thread.Sleep(500);
        stopwatch.Stop();
        Console.WriteLine("Elapsed time {0} ms", stopwatch.ElapsedMilliseconds);
        Console.WriteLine();

        // A1)
        Stopwatch stopwatch1 = Stopwatch.StartNew();

        Console.WriteLine("a2) code 2 A problem");
        int tempA1 = 1;
        for (int col = 0; col < numN; col++)
        {
            for (int row = 0; row < numN; row++)
            {
                matrix[row, col] = tempA1;
                tempA1++;
            }
        }
        for (int row = 0; row < numN; row++)
        {
            for (int col = 0; col < numN; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        System.Threading.Thread.Sleep(500);
        stopwatch.Stop();
        Console.WriteLine("Elapsed time {0} ms", stopwatch1.ElapsedMilliseconds);
        Console.WriteLine();

        // B)
        Console.WriteLine("b)");
        int tempB = 1;
        for (int col = 0; col < numN; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < numN; row++)
                {
                    matrix[row, col] = tempB;
                    tempB++;
                }
            }
            else
            {
                for (int row = numN - 1; row >= 0; row--)
                {
                    matrix[row, col] = tempB;
                    tempB++;
                }
            }

        }
        for (int row = 0; row < numN; row++)
        {
            for (int col = 0; col < numN; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // C)
        Console.WriteLine("c)");
        int tempC = 1;

        for (int row = numN - 1; row >= 0; row--)
        {
            for (int col = 0; col <= numN - row - 1; col++)
            {
                if (col > 0)
                {
                    matrix[row + col, col] = tempC;
                    tempC++;
                }
                else
                {
                    matrix[row, col] = tempC;
                    tempC++;
                }
            }
        }
        for (int col = 1; col < numN; col++)
        {
            for (int row = 0; row < numN - col; row++)
            {
                if (row > 0)
                {
                    matrix[row, col + row] = tempC;
                    tempC++;
                }
                else
                {
                    matrix[row, col] = tempC;
                    tempC++;
                }
            }
        }

        for (int row = 0; row < numN; row++)
        {
            for (int col = 0; col < numN; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // D)
        Console.WriteLine("d)");
        int x = 0;
        int y = 0;
        int count = 1;
        int side = numN;

        while (count <= numN * numN)
        {
            for (int i = 0; i < side; i++) //Down
            {
                matrix[x, y] = count;
                x++;
                count++;
            }
            y++;
            x--;
            side--;// cut first row

            for (int i = 0; i < side; i++) // Right
            {
                matrix[x, y] = count;
                y++;
                count++;
            }
            x--;
            y--;

            for (int i = 0; i < side; i++) //Up
            {
                matrix[x, y] = count;
                x--;
                count++;
            }
            y--;
            x++;
            side--;

            for (int i = 0; i < side; i++) //Left
            {
                matrix[x, y] = count;
                y--;
                count++;
            }
            x++;
            y++;
        }
               
        for (int row = 0; row < numN; row++)
        {
            Console.WriteLine();
            for (int col = 0; col < numN; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
        }
        Console.WriteLine();
    }
}
