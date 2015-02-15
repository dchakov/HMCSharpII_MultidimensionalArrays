//Problem 7.* Largest area in matrix• Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

// matrix 5 row 6 columns
//1 3 2 2 2 4 3 3 3 2 4 4 4 3 1 2 3 3 4 3 1 3 3 1 4 3 3 3 1 1

//1 3 2 2 2 4 
//3 3 3 2 4 4 
//4 3 1 2 3 3 
//4 3 1 3 3 1 
//4 3 3 3 1 1 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace Problem7LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter number for rows");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter number for colunms");
            int numberM = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter {0} separated by space", numberN * numberM);
            string text = Console.ReadLine();

            string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[,] matrix = new string[numberN, numberM];
            bool[,] matrixBool = new bool[numberN, numberM];

            int elementsCounter = 0;

            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    matrix[row, col] = elements[elementsCounter++];
                    matrixBool[row, col] = false;
                }
            }

            Queue myQ = new Queue();
            int largestArea = 0;
            int counter = 0;
            

            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    myQ.Enqueue(matrix[row, col]);
                    matrixBool[row, col] = true;

                    while (myQ.Count > 0)
                    {
                        myQ.Dequeue();
                        for (int i = 0 ; i < numberN-1; i++)
                        {
                            for (int j = 0; j < numberM-1; j++)
                            {
                                if (!matrixBool[i, j] && matrix[row, col] == matrix[i, j])
                                {
                                    myQ.Enqueue(matrix[i, j]);
                                    counter++;
                                    matrixBool[i, j] = true;
                                }
                            }
                        }
                       
                    }
                    if (largestArea < counter)
                    {
                        largestArea = counter;
                    }
                    counter = 0;
                    for (int m = 0; m < numberN; m++)
                    {
                        for (int k = 0; k < numberM; k++)
                        {
                           
                            matrixBool[m, k] = false;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    Console.Write("{0,3}", matrixBool[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(largestArea);
        }
    }

}