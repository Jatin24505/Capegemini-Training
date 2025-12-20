using System;
using System.Collections.Generic;

public class FinanceControlSystem
{
    public static void CheckLoanEligibility()
    {
        Console.Write("Enter your age: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
        {
            Console.WriteLine("Invalid age input.");
            return;
        }

        Console.Write("Enter your monthly income (₹): ");
        if (!double.TryParse(Console.ReadLine(), out double income) || income < 0)
        {
            Console.WriteLine("Invalid income input.");
            return;
        }

        if (age >= 21 && income >= 30000)
            Console.WriteLine("✅ You are eligible for a loan.");
        else
            Console.WriteLine("❌ You are not eligible for a loan.");
    }

    public static void CalculateTax()
    {
        Console.Write("Enter your annual income (₹): ");
        if (!double.TryParse(Console.ReadLine(), out double income) || income < 0)
        {
            Console.WriteLine("Invalid income input.");
            return;
        }

        double tax = 0;
        if (income <= 250000)
            tax = 0;
        else if (income <= 500000)
            tax = 0.05 * (income - 250000);
        else if (income <= 1000000)
            tax = 0.05 * 250000 + 0.20 * (income - 500000);
        else
            tax = 0.05 * 250000 + 0.20 * 500000 + 0.30 * (income - 1000000);

        Console.WriteLine($"Estimated tax payable: ₹{tax:F2}");
    }

    public static void EnterTransactions()
    {
        List<double> transactions = new List<double>();
        Console.WriteLine("Enter up to 5 transaction amounts:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Transaction {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid input. Skipping...");
                continue;
            }

            if (amount < 0)
            {
                Console.WriteLine("Negative amount is invalid. Skipping...");
                continue;
            }

            transactions.Add(amount);
        }

        Console.WriteLine("\n✅ Valid Transactions Entered:");
        foreach (var t in transactions)
            Console.WriteLine($"₹{t:F2}");
    }
}