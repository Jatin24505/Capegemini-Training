// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Student
// {
//     public string Name { get; set; }
//     public int Marks { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create three objects and assign them values
//         List<Student> students = new List<Student>
//         {
//             new Student { Name = "Aman", Marks = 75 },
//             new Student { Name = "Ravi", Marks = 55 },
//             new Student { Name = "Neha", Marks = 62 }
//         };

//         // LINQ Select to shape data without changing original class
//         var result = students.Select(s => new
//         {
//             s.Name,
//             Grade = s.Marks > 60 ? "Pass" : "Fail"
//         });

//         // Display result
//         foreach (var item in result)
//         {
//             Console.WriteLine($"Name: {item.Name}, Grade: {item.Grade}");
//         }

//         // Check type (anonymous type)
//         Console.WriteLine(result.GetType());
//     }
// }
