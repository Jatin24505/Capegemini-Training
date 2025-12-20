using System;

class Bankaccount
{
    // Encapsulation
    private int accountNo;
    private double balance;

    // Static member
    public static string BankName = "State Bank of India";

    // Constructor
    public Bankaccount(int accNo, double initialBalance)
    {
        accountNo = accNo;
        balance = initialBalance;
    }

    // Method Overloading - Deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Overloaded Deposit using ref
    public void Deposit(ref double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            amount = 0;
            Console.WriteLine("Amount Deposited using ref.");
        }
    }

    // Withdraw using out
    public void Withdraw(double amount, out bool success)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            success = true;
        }
        else
        {
            success = false;
        }
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Bank Name : " + BankName);
        Console.WriteLine("Account No: " + accountNo);
        Console.WriteLine("Balance   : " + balance);
    }
}

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter Account Number: ");
//         int accNo;
//         while (!int.TryParse(Console.ReadLine(), out accNo))
//         {
//             Console.Write("Invalid input. Enter numeric Account Number: ");
//         }

//         Console.Write("Enter Initial Balance: ");
//         double balance;
//         while (!double.TryParse(Console.ReadLine(), out balance))
//         {
//             Console.Write("Invalid input. Enter numeric Balance: ");
//         }

//         // Create account
//         Bankaccount account = new Bankaccount(accNo, balance);

//         // Deposit
//         Console.Write("\nEnter Deposit Amount: ");
//         double depAmount;
//         double.TryParse(Console.ReadLine(), out depAmount);
//         account.Deposit(depAmount);

//         // Withdraw
//         Console.Write("\nEnter Withdraw Amount: ");
//         double withAmount;
//         double.TryParse(Console.ReadLine(), out withAmount);

//         bool status;
//         account.Withdraw(withAmount, out status);

//         if (status)
//             Console.WriteLine("Withdrawal Successful.");
//         else
//             Console.WriteLine("Withdrawal Failed.");

//         // Display details
//         account.Display();
//     }
// }