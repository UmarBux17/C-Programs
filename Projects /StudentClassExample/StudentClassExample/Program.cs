using System;

namespace StudentClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myself = new Student(123456789, "John", "Doe", "Senior", "Computer Science");
            DisplayStudentInfo(myself);

            Console.ReadLine();
        }

        // Static method that displays name and major of a student
        static void DisplayStudentInfo(Student student)
        {
            Console.WriteLine("Name: {0}", student.GetFullName());
            Console.WriteLine("Major: {0}", student.Major);
        }
    }
}
