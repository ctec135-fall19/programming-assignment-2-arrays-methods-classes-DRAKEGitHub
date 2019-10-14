using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Student
    {
        #region Student Name
        private string studentName;

        // properties
        public string Name
        {
            // get and set
            get { return studentName; }
            set
            {
                // validation check
                if (value.Length > 20) { studentName = value.Substring(0, 20); }
                else studentName = value;
            }
        }
        #endregion  

        #region Student ID, id, with Exception
        private int studentID;
        public int ID
        {
            get { return studentID; }
            set
            {
                if (value <= 100000 || value >= 999999)
                {
                    throw new System.Exception("ID must be between 100000 and 999999.");
                }
                else studentID = value;
            }
        }
        #endregion

        #region automatic GPA
        // automatic properties for GPA
        public double GPA { get; set; }
        #endregion

        #region Constructors
        // master constructor with parameters for internal data elements
        public Student(string name, int studentID, double gpa)
        {
            Name = name;
            ID = studentID;
            GPA = gpa;
        }

        //default constructor
        public Student() : this("none",111111, 0.0) { }

        // constructor for name and ID using chaining
        public Student(string name) : this(name, 111111, 0.0) { }
        public Student(int studentID) : this("{ 0 }", studentID, 0.0) { }
        #endregion

        // PrintState Method 
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", studentName);
            Console.WriteLine("Name:\t{0}", Name);
            Console.WriteLine("ID:\t{0}", studentID);
            Console.WriteLine("GPA:\t{0}", GPA);
        }
    }
}
