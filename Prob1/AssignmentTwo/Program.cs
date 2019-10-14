/*
 Author: Allison Drake
 Date: 10/12/2019
 CTEC 135: Microsoft Software Development with C#

 Module #3, Programming Assignment 2, Problem 1

 Arrays

 In Main() create:
 - region 1 array of strings: first ten whole numbers, initialize with syntax
 - print array using a foreach loop
 - region 2 array of ints: array of ints size 10
 - initialize with for loop, values being the index multiplied by 10
 - print using a for loop
 - region 3 2D array for multiplcation table up to 12 x 12
 - initialize and format 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Region 1: array of strings
            // Title line, initialize string array
            Console.WriteLine("Region 1: Array of Strings");
            string[] myStringArray = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            // print in sequence using foreach loop
            foreach(string element in myStringArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region Region 2: array of ints
            // create and initialize array of integers
            int[] intArray = new int[10];
            // for loop to multiply index values by 10 and print
            for(int m= 0 ; m<intArray.Length; m++)
            {
                intArray[m] = m * 10;
            }
            Console.WriteLine("Region 2: Array of Integers");
            // use foreach to print each number that is now multiplied by 10
            foreach (int element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region Region 3: 2-D Array
            Console.WriteLine("Region 3: 2D Array");
            // establish 3 x 4 2d array of integers
            int[,] my2DArray = new int[13, 13];
            // nested for loops to do multiplication of table
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    my2DArray[i, j] = i*j;
                }
            }
            // nested for loops to print the rows and columns with tab
            for (int row = 1; row < 13; row++)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                for (int col=1; col<13; col++)
                {
                    Console.Write("| {0}\t",my2DArray[row, col]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            #endregion
        }
    }
}
