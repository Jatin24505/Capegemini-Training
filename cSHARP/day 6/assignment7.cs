// using System;
// using System.Collections;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // ================= TASK 1 =================
//         Console.WriteLine("\n--- TASK 1: DYNAMIC PRODUCT PRICE ANALYSIS ---");

//         Console.Write("Enter number of products: ");
//         int n = int.Parse(Console.ReadLine());

//         int[] prices = new int[n];
//         int sum = 0;

//         for (int i = 0; i < n; i++)
//         {
//             int value;
//             do
//             {
//                 Console.Write($"Enter price for product {i + 1}: ");
//                 value = int.Parse(Console.ReadLine());
//             } while (value <= 0);

//             prices[i] = value;
//             sum += value;
//         }

//         double average = (double)sum / n;
//         Console.WriteLine("Average Price: " + average);

//         Array.Sort(prices);

//         for (int i = 0; i < prices.Length; i++)
//         {
//             if (prices[i] < average)
//                 prices[i] = 0;
//         }

//         int oldLength = prices.Length;
//         Array.Resize(ref prices, oldLength + 5);

//         for (int i = oldLength; i < prices.Length; i++)
//         {
//             prices[i] = (int)average;
//         }

//         Console.WriteLine("\nFinal Product Price Array:");
//         for (int i = 0; i < prices.Length; i++)
//         {
//             Console.WriteLine($"Index {i} => {prices[i]}");
//         }

//         // ================= TASK 2 =================
//         Console.WriteLine("\n--- TASK 2: BRANCH SALES ANALYSIS ---");

//         Console.Write("Enter number of branches: ");
//         int branches = int.Parse(Console.ReadLine());

//         Console.Write("Enter number of months: ");
//         int months = int.Parse(Console.ReadLine());

//         int[,] sales = new int[branches, months];
//         int highestSale = 0;

//         for (int i = 0; i < branches; i++)
//         {
//             for (int j = 0; j < months; j++)
//             {
//                 Console.Write($"Enter sales for Branch {i + 1}, Month {j + 1}: ");
//                 sales[i, j] = int.Parse(Console.ReadLine());

//                 if (sales[i, j] > highestSale)
//                     highestSale = sales[i, j];
//             }
//         }

//         for (int i = 0; i < branches; i++)
//         {
//             int branchTotal = 0;
//             for (int j = 0; j < months; j++)
//                 branchTotal += sales[i, j];

//             Console.WriteLine($"Total sales of Branch {i + 1}: {branchTotal}");
//         }

//         Console.WriteLine("Highest Monthly Sale: " + highestSale);

//         // ================= TASK 3 =================
//         Console.WriteLine("\n--- TASK 3: PERFORMANCE-BASED DATA EXTRACTION ---");

//         int[][] jaggedSales = new int[branches][];

//         for (int i = 0; i < branches; i++)
//         {
//             int count = 0;

//             for (int j = 0; j < months; j++)
//             {
//                 if (sales[i, j] >= average)
//                     count++;
//             }

//             jaggedSales[i] = new int[count];
//             int index = 0;

//             for (int j = 0; j < months; j++)
//             {
//                 if (sales[i, j] >= average)
//                 {
//                     jaggedSales[i][index] = sales[i, j];
//                     index++;
//                 }
//             }
//         }

//         for (int i = 0; i < jaggedSales.Length; i++)
//         {
//             Console.Write($"Branch {i + 1}: ");
//             for (int j = 0; j < jaggedSales[i].Length; j++)
//             {
//                 Console.Write(jaggedSales[i][j] + " ");
//             }
//             Console.WriteLine();
//         }

//         // ================= TASK 4 =================
//         Console.WriteLine("\n--- TASK 4: CUSTOMER TRANSACTION CLEANING ---");

//         Console.Write("Enter number of customer transactions: ");
//         int t = int.Parse(Console.ReadLine());

//         List<int> customerList = new List<int>();

//         for (int i = 0; i < t; i++)
//         {
//             Console.Write($"Enter customer ID {i + 1}: ");
//             customerList.Add(int.Parse(Console.ReadLine()));
//         }

//         HashSet<int> customerSet = new HashSet<int>(customerList);
//         List<int> cleanedList = new List<int>(customerSet);

//         Console.WriteLine("Cleaned Customer IDs:");
//         foreach (int id in cleanedList)
//             Console.WriteLine(id);

//         Console.WriteLine("Duplicates Removed: " + (customerList.Count - cleanedList.Count));

//         // ================= TASK 5 =================
//         Console.WriteLine("\n--- TASK 5: FINANCIAL TRANSACTION FILTERING ---");

//         Console.Write("Enter number of financial transactions: ");
//         int ft = int.Parse(Console.ReadLine());

//         Dictionary<int, double> transactions = new Dictionary<int, double>();

//         for (int i = 0; i < ft; i++)
//         {
//             Console.Write("Enter Transaction ID: ");
//             int id = int.Parse(Console.ReadLine());

//             if (transactions.ContainsKey(id))
//             {
//                 Console.WriteLine("Duplicate Transaction ID not allowed.");
//                 i--;
//                 continue;
//             }

//             Console.Write("Enter Amount: ");
//             double amt = double.Parse(Console.ReadLine());

//             transactions.Add(id, amt);
//         }

//         SortedList<int, double> highValue = new SortedList<int, double>();

//         foreach (KeyValuePair<int, double> kv in transactions)
//         {
//             if (kv.Value >= average)
//                 highValue.Add(kv.Key, kv.Value);
//         }

//         Console.WriteLine("High Value Transactions:");
//         foreach (KeyValuePair<int, double> kv in highValue)
//             Console.WriteLine($"ID: {kv.Key}, Amount: {kv.Value}");

//         // ================= TASK 6 =================
//         Console.WriteLine("\n--- TASK 6: PROCESS FLOW MANAGEMENT ---");

//         Console.Write("Enter number of operations: ");
//         int ops = int.Parse(Console.ReadLine());

//         Queue<string> queue = new Queue<string>();
//         Stack<string> stack = new Stack<string>();

//         for (int i = 0; i < ops; i++)
//         {
//             Console.Write("Enter operation: ");
//             string op = Console.ReadLine();
//             queue.Enqueue(op);
//             stack.Push(op);
//         }

//         Console.WriteLine("\nProcessed Operations:");
//         while (queue.Count > 0)
//             Console.WriteLine(queue.Dequeue());

//         Console.WriteLine("\nUndone Operations:");
//         for (int i = 0; i < 2 && stack.Count > 0; i++)
//             Console.WriteLine(stack.Pop());

//         // ================= TASK 7 =================
//         Console.WriteLine("\n--- TASK 7: LEGACY DATA RISK DEMONSTRATION ---");

//         Console.Write("Enter number of users: ");
//         int users = int.Parse(Console.ReadLine());

//         Hashtable userTable = new Hashtable();
//         ArrayList userList = new ArrayList();

//         for (int i = 0; i < users; i++)
//         {
//             Console.Write("Enter username: ");
//             string name = Console.ReadLine();

//             Console.Write("Enter role: ");
//             string role = Console.ReadLine();

//             userTable.Add(name, role);
//             userList.Add(name);
//             userList.Add(role);
//             userList.Add(i); // mixed type
//         }

//         Console.WriteLine("\nHashtable Data:");
//         foreach (DictionaryEntry de in userTable)
//             Console.WriteLine(de.Key + " => " + de.Value);

//         Console.WriteLine("\nArrayList Data (Mixed Types):");
//         foreach (object obj in userList)
//             Console.WriteLine(obj);

//         Console.WriteLine("\nRisk: ArrayList allows mixed data types causing runtime casting errors.");
//     }
// }
