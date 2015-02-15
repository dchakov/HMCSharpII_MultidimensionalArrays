//Problem 5. Sort by string length• You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Please, enter lenght of Array");
        int numM = int.Parse(Console.ReadLine());
        string[] myArray = new string[numM];

        Console.WriteLine("Please, enter text on {0} new lines",numM);
        for (int i = 0; i < numM; i++)
        {
            myArray[i] = Console.ReadLine();
        }
        Array.Sort(myArray, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine();
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}

