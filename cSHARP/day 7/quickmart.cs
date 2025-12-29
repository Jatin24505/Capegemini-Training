// using System;


//     // ================= ENTITY CLASS =================
//     public class SaleTransaction
//     {
//         public string InvoiceNo { get; set; }
//         public string CustomerName { get; set; }
//         public string ItemName { get; set; }
//         public int Quantity { get; set; }
//         public decimal PurchaseAmount { get; set; }
//         public decimal SellingAmount { get; set; }

//         public string ProfitOrLossStatus { get; set; }
//         public decimal ProfitOrLossAmount { get; set; }
//         public decimal ProfitMarginPercent { get; set; }

//         // Calculation Logic
//         public void CalculateProfitOrLoss()
//         {
//             if (SellingAmount > PurchaseAmount)
//             {
//                 ProfitOrLossStatus = "PROFIT";
//                 ProfitOrLossAmount = SellingAmount - PurchaseAmount;
//             }
//             else if (SellingAmount < PurchaseAmount)
//             {
//                 ProfitOrLossStatus = "LOSS";
//                 ProfitOrLossAmount = PurchaseAmount - SellingAmount;
//             }
//             else
//             {
//                 ProfitOrLossStatus = "BREAK-EVEN";
//                 ProfitOrLossAmount = 0;
//             }

//             ProfitMarginPercent = (ProfitOrLossAmount / PurchaseAmount) * 100;
//         }
//     }

//     // ================= MANAGER / SERVICE =================
//     public class TransactionManager
//     {
//         public static SaleTransaction ? LastTransaction;
//         public static bool HasLastTransaction = false;

//         // 1. Create/Register Method
//         public static void CreateTransaction()
//         {
//             SaleTransaction tx = new SaleTransaction();

//             Console.Write("Enter Invoice No: ");
//             tx.InvoiceNo = Console.ReadLine();
//             if (string.IsNullOrWhiteSpace(tx.InvoiceNo))
//             {
//                 Console.WriteLine("Invoice No cannot be empty.");
//                 return;
//             }

//             Console.Write("Enter Customer Name: ");
//             tx.CustomerName = Console.ReadLine();

//             Console.Write("Enter Item Name: ");
//             tx.ItemName = Console.ReadLine();

//             Console.Write("Enter Quantity: ");
//             if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
//             {
//                 Console.WriteLine("Quantity must be greater than 0.");
//                 return;
//             }
//             tx.Quantity = qty;

//             Console.Write("Enter Purchase Amount (total): ");
//             if (!decimal.TryParse(Console.ReadLine(), out decimal purchase) || purchase <= 0)
//             {
//                 Console.WriteLine("Purchase Amount must be greater than 0.");
//                 return;
//             }
//             tx.PurchaseAmount = purchase;

//             Console.Write("Enter Selling Amount (total): ");
//             if (!decimal.TryParse(Console.ReadLine(), out decimal selling) || selling < 0)
//             {
//                 Console.WriteLine("Selling Amount cannot be negative.");
//                 return;
//             }
//             tx.SellingAmount = selling;

//             tx.CalculateProfitOrLoss();

//             LastTransaction = tx;
//             HasLastTransaction = true;

//             Console.WriteLine("\nTransaction saved successfully.");
//             PrintCalculation(tx);
//         }

//         // 2. View Method
//         public static void ViewLastTransaction()
//         {
//             if (!HasLastTransaction)
//             {
//                 Console.WriteLine("No transaction available. Please create a new transaction first.");
//                 return;
//             }

//             SaleTransaction tx = LastTransaction;

//             Console.WriteLine("\n-------------- Last Transaction --------------");
//             Console.WriteLine($"InvoiceNo: {tx.InvoiceNo}");
//             Console.WriteLine($"Customer: {tx.CustomerName}");
//             Console.WriteLine($"Item: {tx.ItemName}");
//             Console.WriteLine($"Quantity: {tx.Quantity}");
//             Console.WriteLine($"Purchase Amount: {tx.PurchaseAmount:F2}");
//             Console.WriteLine($"Selling Amount: {tx.SellingAmount:F2}");
//             Console.WriteLine($"Status: {tx.ProfitOrLossStatus}");
//             Console.WriteLine($"Profit/Loss Amount: {tx.ProfitOrLossAmount:F2}");
//             Console.WriteLine($"Profit Margin (%): {tx.ProfitMarginPercent:F2}");
//             Console.WriteLine("--------------------------------------------");
//         }

//         // 3. Calculation Method
//         public static void RecalculateProfitLoss()
//         {
//             if (!HasLastTransaction)
//             {
//                 Console.WriteLine("No transaction available. Please create a new transaction first.");
//                 return;
//             }

//             LastTransaction.CalculateProfitOrLoss();
//             PrintCalculation(LastTransaction);
//         }

//         private static void PrintCalculation(SaleTransaction tx)
//         {
//             Console.WriteLine($"Status: {tx.ProfitOrLossStatus}");
//             Console.WriteLine($"Profit/Loss Amount: {tx.ProfitOrLossAmount:F2}");
//             Console.WriteLine($"Profit Margin (%): {tx.ProfitMarginPercent:F2}");
//             Console.WriteLine("------------------------------------------------------");
//         }
//     }

//     // ================= MAIN PROGRAM =================
// //     class Program
// //     {
// //         static void Main()
// //         {
// //             bool running = true;

// //             while (running)
// //             {
// //                 Console.WriteLine("\n================== QuickMart Traders ==================");
// //                 Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
// //                 Console.WriteLine("2. View Last Transaction");
// //                 Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
// //                 Console.WriteLine("4. Exit");
// //                 Console.Write("Enter your option: ");

// //                 string input = Console.ReadLine();

// //                 switch (input)
// //                 {
// //                     case "1":
// //                         TransactionManager.CreateTransaction();
// //                         break;

// //                     case "2":
// //                         TransactionManager.ViewLastTransaction();
// //                         break;

// //                     case "3":
// //                         TransactionManager.RecalculateProfitLoss();
// //                         break;

// //                     case "4":
// //                         Console.WriteLine("Thank you. Application closed normally.");
// //                         running = false;
// //                         break;

// //                     default:
// //                         Console.WriteLine("Invalid option. Please select a valid menu choice.");
// //                         break;
// //                 }
// //             }
// //         }
// //     }
// // }
