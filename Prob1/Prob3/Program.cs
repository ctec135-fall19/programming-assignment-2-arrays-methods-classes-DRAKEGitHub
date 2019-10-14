/*
 Author: Allison Drake
 Date: 10/12/2019
 CTEC 135: Microsoft Software Development with C#

 Module #3, Programming Assignment 2, Problem 3

Class
-Create a student Class with name field and the associated set and get methods
-create ID property with validation code to set method
- create automatic GPA property
- create master constructor with all three internal data elements
- create a constructor that has parameters for name and ID and uses chaining
- create a default constructor
- code a "PrintState()" method
-in Main() show the use of each constructor, print the state to show behavior.
- use the accessor and mutator for the name field
- use of both properties
- try/catch block that demonstrates the exeception
- regions as appropriate

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test of three constructors
            Console.WriteLine("Default Values from Student a:");
            Student a = new Student("Allison Drake", 889998, 3.89);
            a.PrintState();
            Console.WriteLine();

            // add info using master constructor
            Console.WriteLine("Add Student b:");
            Student b = new Student();
            b.Name = "Blaine.Blodgette";
            b.ID = 999998;
            b.GPA = 3.5;
            b.PrintState();
            Console.WriteLine();

            // Default values constructor
            Console.WriteLine("Add Student c:");
            Student c = new Student();
            c.PrintState();
            Console.WriteLine();

            // try/catch for the exception ID 
            Console.WriteLine("Press enter to test the ID validation with the number 99 on Student b.");
            Console.ReadKey();
            try
            {
                b.ID = 99;
            } catch (Exception e) { Console.WriteLine(e.Message); 
            } finally {
                Console.WriteLine();
                Console.WriteLine("Student b's values are current set at: ");
                b.PrintState();
            }

        }
    }
}
