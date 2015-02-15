//Problem 6.* Matrix class• Write a class  Matrix , to hold a matrix of integers. 
//Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and  ToString() .

namespace MatrixClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix
    {
        // Field name
        private int row;
        private int col;
        private int[,] matrix;


        public int Row
        {
            get
            {
                return this.row;
            }
        }
        public int Column
        {
            get
            {
                return this.col;
            }
        }
        // Indexer for accessing the matrix content
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }
        // Constructor with parameters

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new int[row, col];
        }
        // Method fill the matrix
        public void FillMatrix()
        {
            Random randNumber = new Random();

            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    this.matrix[i, j] = randNumber.Next(50);
                }
            }
        }

        // Method print Matrix
        public void PrintMatrix()
        {
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write("{0,6}", this.matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Method Adding returns new matrix

        public static Matrix operator +(Matrix one, Matrix two)
        {
            Matrix result = new Matrix(one.Row, one.Column);

            for (int row = 0; row < one.Row; row++)
            {
                for (int col = 0; col < one.Column; col++)
                {
                    result[row, col] = one[row, col] + two[row, col];
                }
            }
            return result;
        }
        // Metod Subtracting new matrix

        public static Matrix operator -(Matrix one, Matrix two)
        {
            Matrix result = new Matrix(one.Row, one.Column);

            for (int row = 0; row < one.Row; row++)
            {
                for (int col = 0; col < one.Column; col++)
                {
                    result[row, col] = one[row, col] - two[row, col];
                }
            }
            return result;
        }

        // Metod Multiplying new matrix

        public static Matrix operator *(Matrix one, Matrix two)
        {
            Matrix result = new Matrix(one.Row, one.Column);

            for (int row = 0; row < one.Row; row++)
            {
                for (int col = 0; col < one.Column; col++)
                {
                    result[row, col] = one[row, col] * two[row, col];
                }
            }
            return result;
        }
        // https://msdn.microsoft.com/en-us/library/system.object.tostring(v=vs.110).aspx
        // https://msdn.microsoft.com/en-us/library/vstudio/ms173154(v=vs.100).aspx

        public override string ToString()
        {
            string result = "";
            for (int row = 0; row < this.Row; row++)
            {
                for (int col = 0; col < this.Column; col++)
                {
                    result += matrix[row, col] + " ";
                }
            }
            return result;
        }
    }

    class MatrixClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter number for rows");
            int numberOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter number for colunms");
            int numberOfColumns = int.Parse(Console.ReadLine());

            Matrix firstMatrix = new Matrix(numberOfRows, numberOfColumns);
            firstMatrix.FillMatrix();
            firstMatrix.PrintMatrix();
            Console.WriteLine();
            Matrix secondMatrix = new Matrix(numberOfRows, numberOfColumns);
            secondMatrix.FillMatrix();
            secondMatrix.PrintMatrix();

            Console.WriteLine();
            Matrix addition = firstMatrix + secondMatrix;
            addition.PrintMatrix();

            Console.WriteLine();
            Matrix subtracting = firstMatrix - secondMatrix;
            subtracting.PrintMatrix();

            Console.WriteLine();
            Matrix multiplaying = firstMatrix * secondMatrix;
            multiplaying.PrintMatrix();

            Console.WriteLine();
            Console.WriteLine(firstMatrix.ToString());

        }
    }
}