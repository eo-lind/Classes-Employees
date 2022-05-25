using System;

namespace Classes
{
    public class Employee
    {

        // Properties
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }

        public Employee(string name, string title)
        {
            EmployeeName = name;
            EmployeeTitle = title;
    
        }

    }
}