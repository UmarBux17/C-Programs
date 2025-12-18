using System;
namespace AdvancedListTask
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeID { get; set; }
        public string jobName { get; set; }

        public override string? ToString()
        {
            return $"First Name: {firstName}\nLast Name: " +
                $"{lastName}\nIdentity Number: {employeeID}\nJob Name: {jobName}";
        }
    }
}

