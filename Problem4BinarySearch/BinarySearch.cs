//Problem 4. Binary search• Write a program, that reads from the console an array of  N  integers and an integer  K ,
//sorts the array and using the method  Array.BinSearch()  finds the largest number in the array which is ≤  K . 

using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter sequence of numbers separated by space");
        string text = Console.ReadLine();
        string[] textArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numberArray = new int[textArray.Length];
        for (int i = 0; i < textArray.Length; i++)
        {
            numberArray[i] = int.Parse(textArray[i]);
        }

        Console.WriteLine("Please, enter number K");
        int numberK = int.Parse(Console.ReadLine());

        Array.Sort(numberArray);

        int index = Array.BinarySearch(numberArray, numberK);

        Console.WriteLine();
        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.Write(numberArray[i] + " ");
        }
        Console.WriteLine();

        if (index < 0)
        {
            index = ~index;
            if (index == 0)
            {
                Console.WriteLine("No such number. {0} is less than first number of Array {1}", numberK, numberArray[index]);
            }
            else
            {
                Console.WriteLine("Largest number in the array which is less than K is {0}", numberArray[index - 1]);
            }
        }
        else
        {
            Console.WriteLine("Largest number in the array which is equal to K = {0}", numberArray[index]);

        }

    }
}
