/*
 Author: Allison Drake
 Date: 10/12/2019
 CTEC 135: Microsoft Software Development with C#

 Module #3, Programming Assignment 2, Problem 2

 Methods

 In a separate Project, create a static method that demonstrates call by value.
 Create a static method that demonstrates call by reference. 
 Add print statements to demonstrate both concepts appropriately.
 Create static methods that demonstrate method overloading.
 Region 1: call by value, Region 2: call by reference, Region 3: overloading

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize variables in calling method
            int minQuantity = 12;
            string[] produceList = new string[] { "apples", "bananas", "carrots", "dill", "eggplant", "watermelon" };

            //print out original values
            Console.WriteLine("Original List of Produce Categories:");
            foreach(string produceCategory in produceList)
            {
                Console.WriteLine(produceCategory);
            }
            Console.WriteLine();
            Console.ReadLine();

            #region Region 1: Call by Value
            produceUpdateMethod(minQuantity, produceList);
            Console.WriteLine("Call by Value:");
            Console.WriteLine("minQuantity: {0}", minQuantity);
            foreach(string produceCategory in produceList)
            {
                Console.WriteLine(produceCategory);
            }
            Console.WriteLine();
            Console.ReadLine();
            #endregion

            #region Region 2: Call by Reference

            Console.WriteLine("Values after Call by Reference:");
            Console.WriteLine("minQuantity: {0}", minQuantity);
            foreach (string produceCategory in produceList)
            {
                Console.WriteLine(produceCategory);
            }
            Console.WriteLine();
            Console.ReadLine();

            #endregion


            #region Region 3: Overloading
            {
                produceUpdateMethod(produceList);
            }
            Console.WriteLine("Values after Overloading:");
            Console.WriteLine("minQuantity: {0}", minQuantity);
            foreach (string produceCategory in produceList)
            {
                Console.WriteLine(produceCategory);
            }
            Console.WriteLine();
            Console.ReadLine();
            #endregion
        }
        // static method that call by value and by reference
        static void produceUpdateMethod(int arg1, string[] arg2)
        {
            arg1 = 20;
            arg2[4] = "cellery";
        }

        // When called produceUpateMethod will replace the string 5
        // replaces by reference
        static void produceUpdateMethod(string[] arg3)
        {
            arg3[5] = "cauliflower";
        }
    }
}
