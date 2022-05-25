using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

       
            public Company(string name, DateTime theDate)
            {
                Name = name;
                CreatedOn = theDate;
                Employees = new List<Employee>();
            }

            public void PrintEmployees()
            {
                foreach (Employee employee in Employees)
                {
                    Console.WriteLine($"{employee.EmployeeName} is an employee of {Name} and holds the position of {employee.EmployeeTitle}.");
                }
            }

    
    }
}