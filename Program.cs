using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company rupeCo = new Company("RupertCorp", DateTime.Now);

            // Create three employees

            Employee employee1 = new Employee("Bosco Cannoli", "Chief Officer in Charge of Monster Combat");
            Employee employee2 = new Employee("Pepper Dots", "Head of Chasing and Songs");
            Employee employee3 = new Employee("Jumpington J. Frog", "Assistant to the Regional Manager" );

            // Assign the employees to the company
            rupeCo.Employees.Add(employee1);
            rupeCo.Employees.Add(employee2);
            rupeCo.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            rupeCo.PrintEmployees();
        }
    }
}

















// using System;
// using System.Collections.Generic;

// namespace Classes
// {
//     class Program
//     {

//         static void Main(string[] args)
//         {

//             // Create an instance of a company. Name it whatever you like.
//             // --------------------------------------------------
//             public class Company
//             {
//                 public string Name { get; set; }
//                 public string Address { get; set; }
//             }

//             


//             // Create three employees
//             // --------------------------------------------------
//             public class Employee
//             {
//                 public string NameFirst { get; set; }
//                 public string NameLast { get; set; }
//             }

           
//             // --------------------------------------------------
//         }


//     // Assign the employees to the company



//     /*
//         Iterate the company's employee list and generate the
//         simple report shown above
//     */


// }
// }