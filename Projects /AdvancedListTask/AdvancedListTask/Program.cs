using System.Xml.Linq;

namespace AdvancedListTask {

    class Program {

        static List<Employee> employee;

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the name of the department: ");
            string department = Console.ReadLine();

            Console.Write("\nEnter the number of employees in the department: ");
            int numEmployees = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n----For Each Employee----");
            for (int i = 0; i < numEmployees; i++)
            {
                Console.Write("\nEnter employee fisrt name: ");
                string fName = Console.ReadLine();

                Console.Write("Enter employee last name: ");
                string lName = Console.ReadLine();

                Console.Write("Enter employee ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("Enter employee job name: ");
                string job = Console.ReadLine();

                employees.Add(new Employee
                {
                    firstName = fName,
                    lastName = lName,
                    employeeID = id,
                    jobName = job
                });

                Console.WriteLine();
            }

            Console.WriteLine("---List of Employees---");
            int counter = 1;
            foreach (var item in employees)
            {
                Console.WriteLine($"\n- Employee ({counter})\n{item}");
                counter++;
            }
            Console.WriteLine("\n-----End of List-----");

            Console.ReadLine();
            Console.ReadLine();//open console
        }
    }

}

