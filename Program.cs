using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Finance Control System ---");
            Console.WriteLine("1. Check Loan Eligibility");
            Console.WriteLine("2. Calculate Tax");
            Console.WriteLine("3. Enter Transactions");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    FinanceControlSystem.CheckLoanEligibility();
                    break;
                case "2":
                    FinanceControlSystem.CalculateTax();
                    break;
                case "3":
                    FinanceControlSystem.EnterTransactions();
                    break;
                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select from 1 to 4.");
                    break;
            }
        }
    }
}