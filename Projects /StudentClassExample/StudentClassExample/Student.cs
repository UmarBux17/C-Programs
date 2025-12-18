using System;

namespace StudentClassExample
{
    class Student
    {
        // Properties
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }

        // Constructors
        public Student()
        {
            // Default constructor with no parameters
        }

        public Student(int studentNumber, string firstName, string lastName, string classification, string major)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Classification = classification;
            Major = major;
        }

        // Instance method
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

