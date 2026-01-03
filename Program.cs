using System;
using System.Data.Common;
using Microsoft.VisualBasic;

// class Program
// {
//     static void Main(string[] args)
//     {
       // var person  = (Id: 1, Name: "John Doe", Age: 30);


        // Console.WriteLine(person.Id); 
        
        // Console.WriteLine(person.Name);
        // //type of id
        // Console.WriteLine(person.Id.GetType());
        // //type of person
        // Console.WriteLine(person.GetType());
           // using discard _
        // var (_, name, _) = person;
        
        // Console.WriteLine("Name: " + name);

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public void Deconstruct(out int id, out string name)
//     {
//         id = Id;
//         name = Name;
//     }
// }

//    var s = new Student { Id = 1, Name = "Amit" };
//    var (sid, sname) = s;

// Console.WriteLine(sid);
// Console.WriteLine(sname);

//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         int a = 10;
//         int b = 20;

//         // Method call with tuple deconstruction
//         (int sum, int average, int differ) = Calculate(a, b);

//         Console.WriteLine("Number 1: " + a);
//         Console.WriteLine("Number 2: " + b);
//         Console.WriteLine("Sum: " + sum);
//         Console.WriteLine("Average: " + average);
//         Console.WriteLine("Difference: " + differ);
//     }

//     // Tuple return method
//     static (int Sum, int Average,int differ) Calculate(int a, int b)
//     {
//         return (a + b, (a + b) / 2, a - b);
//     }
// }

// class Valid
// {
//   static void Main()
//     {
//         static (bool isValid, string message) ValidateInput(string input)
//         {
//             if (string.IsNullOrWhiteSpace(input))
            
//                 return (false, "Input cannot be empty or whitespace.");
        
//             return (true, "Input is valid.");
//         }
//         var response = ValidateInput("admin");
//         Console.WriteLine(response.message);
//     }  
// }
// using System;

// class Student
// {
//     public int Id { get; set; }
//     public string  Name { get; set; }

//     // Deconstruct method
//     public void Deconstruct(out int id, out string name)
//     {
//         id = Id;
//         name = Name;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create Student object
//         Student s = new Student
//         {
//             Id = 1,
//             Name = "Amit"
//         };

//         // Deconstruction
//         var (sid, sname) = s;

//         // Output
//         Console.WriteLine(sid);
//         Console.WriteLine(sname);
//         Console.WriteLine(s.GetType());
//     }
// }
// using System;
// using System.Linq;
// using System.Runtime.CompilerServices;
// class Program
// {
//     static void Main()
//     {
//         int[] Number ={1,2,34,5,6,7};
//         //order by descending
//         var evennumber = Number.Where(n => n % 2 == 0);

//         foreach (var v in val)
//         {
//             Console.WriteLine(v);
            
//         }
//         Console.WriteLine("Even Numbers:");
//         foreach (var num in evennumber)
//         {
//             Console.WriteLine(num);
           
//         }
//          Console.WriteLine(evennumber.GetType());

//     }
  
// }
// using System;

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     // Deconstruct method
//     public void Deconstruct(out int id, out string name)
//     {
//         id = Id;
//         name = Name;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create Student object
//         Student s = new Student
//         {
//             Id = 1,
//             Name = "Amit"
//         };

//         // Deconstruction
//         var (sid, sname) = s;

//         // Output
//         Console.WriteLine(sid);
//         Console.WriteLine(sname);
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Linq;

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
//             new Student { Name = "Ravi", Marks = 95 },
//             new Student { Name = "Neha", Marks = 60 }
//         };

//         // Order by Marks (Descending) + Select + Anonymous Type
//         var result = students
//             .OrderByDescending(s => s.Marks)
//             .Select(s => new
//             {
//                 s.Name,
//                 s.Marks,
//                 Grade = s.Marks > 60 ? "Pass" : "Fail"
//             })
//             .ToList();   // Convert to List

//         // Display result
//         foreach (var item in result)
//         {
//             Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}, Grade: {item.Grade}");
//         }

//         // Check type
//         Console.WriteLine(result.GetType());
//     }
// }
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

// using System;
// class Program
// {
//     static void Main()
//     {
//         using (Handler h = new Handler())
//         {
//             Console.WriteLine("Inside using block");
//         }

//         Console.WriteLine("byeeeeeeeeee");
//     }
// }
using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

//         for (int i = 0; i < 10000; i++)
//         {
//             object obj = new object(); // Gen 0 allocation
//         }

//         Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

//         GC.Collect(); 
//         GC.WaitForPendingFinalizers();

//         Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
//         Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
//     }
// }
using System.Text;

class Program{
    static void Main(){
    //     string str="heyyyy";
    //     Console.WriteLine(str.ToUpper());
    //     Console.WriteLine(str.ToLower());
    //     StringBuilder sb = new StringBuilder();
    //     sb.Append("hello");
    //     sb.Append(" world");
    //     Console.WriteLine(sb.ToString());
    //     sb.AppendLine("!");
    //     Console.WriteLine(sb.ToString());
    //     sb.Insert(5, ",");
    //     Console.WriteLine(sb.ToString());
    //     sb.Remove(5,1);
    //     Console.WriteLine(sb.ToString());
    //     sb.Replace("world", "C#");
    //     Console.WriteLine(sb.ToString());
    //     long mem = GC.GetTotalMemory(false);
    //     Console.WriteLine("Memory used: " + mem + " bytes");
        StringBuilder sb1 = new StringBuilder();
        for(int i=0;i<4;i++){
            sb1.Append("Line " + i + "\n");
        }
        String  RESULT = sb1.ToString();
        Console.WriteLine(RESULT);
        StringBuilder sb2 = new StringBuilder("hello");
         StringBuilder sb3 = new StringBuilder("hello");
         Console.WriteLine(sb2.Equals(sb3));
         StringBuilder sb4 = sb3;
         Console.WriteLine(sb3.Equals(sb4));
         Console.WriteLine(sb2==sb3);
        //  Console.WriteLine(sb3==sb4);
        //  Console.WriteLine(sb2.GetHashCode());
        //  Console.WriteLine(sb3.GetHashCode());
        //  Console.WriteLine(sb4.GetHashCode());
         DateTime now = DateTime.Now;
         DateTime today = DateTime.Today;
         Console.WriteLine($"{now},{today}");
        

         




    }
}