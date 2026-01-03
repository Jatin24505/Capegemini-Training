// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee
// {
//     public string Name { get; set; }
//     public int Salary { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { Name = "Amit", Salary = 50000 },
//             new Employee { Name = "Ravi", Salary = 70000 },
//             new Employee { Name = "Neha", Salary = 60000 }
//         };

//         // Sort employees by salary (low → high)
//         var sortedBySalary = employees.OrderBy(e => e.Salary);

//         foreach (var emp in sortedBySalary)
//         {
//             Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
//         }
//     }
// }
