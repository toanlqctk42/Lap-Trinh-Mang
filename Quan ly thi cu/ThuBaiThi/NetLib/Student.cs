using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetLib
{
    public class Student
    {
        public string MSSV { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public Student()
        {

        }

        public Student(string mssv, string firstName, string lastName)
        {
            MSSV = mssv;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
