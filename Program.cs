using System;

class Program
{
    static void Main()
    {
        debitCard debit = new debitCard();
        creditCard credit = new creditCard();
        int choice;

        do
        {
            Console.WriteLine("\n-- Banking Services Menu --");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("ENTER YOUR CHOICE: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n-- Debit Card Management --");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. EMI Burden Check");
                    Console.WriteLine("3. Daily Spending Calculator");
                    Console.WriteLine("4. Minimum Balance Check");
                    Console.Write("ENTER YOUR CHOICE: ");
                    int debitChoice = Convert.ToInt32(Console.ReadLine());

                    switch (debitChoice)
                    {
                        case 1: debit.atmwithdrawl(); break;
                        case 2: debit.emiBurden(); break;
                        case 3: debit.dailySpendingCalculator(); break;
                        case 4: debit.minimumbalance(); break;
                        default: Console.WriteLine("Invalid choice for Debit Operations."); break;
                    }
                    break;

                case 2:
                    Console.WriteLine("\n-- Credit Card Management --");
                    Console.WriteLine("1. Credit Limit Check");
                    Console.WriteLine("2. Maturity Amount");
                    Console.WriteLine("3. Reward Points Calculation");
                    Console.WriteLine("4. Employee Bonus");
                    Console.Write("ENTER YOUR CHOICE: ");
                    int creditChoice = Convert.ToInt32(Console.ReadLine());

                    switch (creditChoice)
                    {
                        case 1: credit.netsalarycredit(); break;
                        case 2: credit.maturityAmount(); break;
                        case 3: credit.creditCardReward(); break;
                        case 4: credit.employeeBonus(); break;
                        default: Console.WriteLine("Invalid choice for Credit Operations."); break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 3);
    }
}