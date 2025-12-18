namespace BasicCollectionsThree {
    class Program {

        static void Main(string[] args)
        {

            // advanced List of T's in OOP
            List<Student> students = new List<Student>()
            {

            //new object per student to consume the properties
            new Student { firstName = "Umar", lastName = "Bux", studentID = 100 },
            new Student { firstName = "John", lastName = "Smith", studentID = 200 },
            new Student { firstName = "Sue", lastName = "Ellen", studentID = 300 },
            new Student { firstName = "Broke", lastName = "Guy", studentID = 000 } };

            Console.WriteLine("The list of students >>>\n");

            foreach (Student s in students)
            {
                Console.WriteLine("First name: {0}, Last name: {1}, Student ID: {2}"
                    ,s.firstName,s.lastName,s.studentID);
            }


            Console.ReadLine();
        }


    }



}

