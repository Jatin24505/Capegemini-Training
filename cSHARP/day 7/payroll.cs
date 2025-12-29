// using System;
// using System.Collections.Generic;
// using System.Linq;

// public abstract class EmployeeRecord
// {
//     public string EmployeeName { get; set; }
//     public double[] WeeklyHours { get; set; }

//     public abstract double GetMonthlyPay();
// }

// public class FullTimeEmployee : EmployeeRecord
// {
//     public double HourlyRate { get; set; }
//     public double MonthlyBonus { get; set; }

//     public override double GetMonthlyPay()
//     {
//         return WeeklyHours.Sum() * HourlyRate + MonthlyBonus;
//     }
// }

// public class ContractEmployee : EmployeeRecord
// {
//     public double HourlyRate { get; set; }

//     public override double GetMonthlyPay()
//     {
//         return WeeklyHours.Sum() * HourlyRate;
//     }
// }

// public class Program
// {
//     // Static Collection
//     public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

//     public void RegisterEmployee(EmployeeRecord record)
//     {
//         PayrollBoard.Add(record);
//     }

//     public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
//     {
//         Dictionary<string, int> result = new Dictionary<string, int>();

//         foreach (EmployeeRecord emp in records)
//         {
//             int count = emp.WeeklyHours.Count(h => h >= hoursThreshold);

//             if (count > 0)
//             {
//                 result.Add(emp.EmployeeName, count);
//             }
//         }

//         return result;
//     }

//     public double CalculateAverageMonthlyPay()
//     {
//         if (PayrollBoard.Count == 0)
//             return 0;

//         double total = 0;

//         foreach (EmployeeRecord emp in PayrollBoard)
//         {
//             total += emp.GetMonthlyPay(); // Polymorphism
//         }

//         return total / PayrollBoard.Count;
//     }

//     static void Main()
//     {
//         Program program = new Program();
//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("\n1. Register Employee");
//             Console.WriteLine("2. Show Overtime Summary");
//             Console.WriteLine("3. Calculate Average Monthly Pay");
//             Console.WriteLine("4. Exit");
//             Console.WriteLine("\nEnter your choice:");

//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("\nSelect Employee Type (1-Full Time, 2-Contract):");
//                     int type = int.Parse(Console.ReadLine());

//                     Console.WriteLine("\nEnter Employee Name:");
//                     string name = Console.ReadLine();

//                     Console.WriteLine("\nEnter Hourly Rate:");
//                     double rate = double.Parse(Console.ReadLine());

//                     double[] hours = new double[4];
//                     Console.WriteLine("\nEnter weekly hours (Week 1 to 4):");
//                     for (int i = 0; i < 4; i++)
//                     {
//                         hours[i] = double.Parse(Console.ReadLine());
//                     }

//                     if (type == 1)
//                     {
//                         Console.WriteLine("\nEnter Monthly Bonus:");
//                         double bonus = double.Parse(Console.ReadLine());

//                         FullTimeEmployee fte = new FullTimeEmployee
//                         {
//                             EmployeeName = name,
//                             HourlyRate = rate,
//                             MonthlyBonus = bonus,
//                             WeeklyHours = hours
//                         };

//                         program.RegisterEmployee(fte);
//                     }
//                     else
//                     {
//                         ContractEmployee ce = new ContractEmployee
//                         {
//                             EmployeeName = name,
//                             HourlyRate = rate,
//                             WeeklyHours = hours
//                         };

//                         program.RegisterEmployee(ce);
//                     }

//                     Console.WriteLine("\nEmployee registered successfully");
//                     break;

//                 case 2:
//                     Console.WriteLine("\nEnter hours threshold:");
//                     double threshold = double.Parse(Console.ReadLine());

//                     Dictionary<string, int> overtime =
//                         program.GetOvertimeWeekCounts(PayrollBoard, threshold);

//                     if (overtime.Count == 0)
//                     {
//                         Console.WriteLine("\nNo overtime recorded this month");
//                     }
//                     else
//                     {
//                         foreach (var item in overtime)
//                         {
//                             Console.WriteLine($"{item.Key} - {item.Value}");
//                         }
//                     }
//                     break;

//                 case 3:
//                     double avg = program.CalculateAverageMonthlyPay();
//                     Console.WriteLine($"\nOverall average monthly pay: {avg}");
//                     break;

//                 case 4:
//                     Console.WriteLine("\nLogging off — Payroll processed successfully!");
//                     running = false;
//                     break;
//             }
//         }
//     }
// }
