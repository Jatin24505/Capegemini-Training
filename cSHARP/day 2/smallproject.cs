using System;
public class debitCard
{
  public void atmwithdrawl()
    {
        Console.Write("Enter the amount to withdraw: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        if (amount <= 40000)
        {
            Console.WriteLine("Withdrawal permitted within daily limit.");
        }
        else
        {
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
        }
    }
    public void emiBurden()
    {
        Console.WriteLine("user enter monthly income:");
         double income = Convert.ToDouble(Console.ReadLine()); 
         Console.WriteLine("user enter emi amount:");
            double emi = Convert.ToDouble(Console.ReadLine());   
            if(emi<=income*0.4)
            {
                Console.WriteLine("EMI burden is manageable.");
            }
            else
            {
                Console.WriteLine("EMI exceeds sale income limit");
            }
    }
    public void dailySpendingCalculator()
    {
        Console.WriteLine("number of transactions :");
        int transactions = Convert.ToInt32(Console.ReadLine());
        double total = 0;

        for (int i = 1; i <= transactions; i++)
        {
            Console.WriteLine($"Enter amount for transaction {i}:");
            total += Convert.ToDouble(Console.ReadLine());

            
        }
        Console.WriteLine($"Total debit amount for the day: {total}");
    }
    public void minimumbalance()
    {
        Console.Write("enter current balance:");
        double balance = Convert.ToDouble(Console.ReadLine());
        if (balance < 2000)
        {
            Console.WriteLine("Minimum balance not maintained. A penalty will be applied.");
        }
        else
        {
            Console.WriteLine("Minimum balance requirements satisfied.");
        }
    }
}

public class creditCard
{
    public void netsalarycredit()
    {
        Console.Write("enter gross salary:");
        double grossSalary = Convert.ToDouble(Console.ReadLine());
        double netSalary = grossSalary * 0.1 - grossSalary;
        Console.WriteLine($"Net salary after 10% deductions: {netSalary}");
    }
    public void maturityAmount()
    {
        Console.Write("enter principal amount:");
        double principal= Convert.ToDouble(Console.ReadLine());
        Console.Write("enter rate of interest:");
        double rate= Convert.ToDouble(Console.ReadLine());
        Console.Write("enter time in years:");
        double time= Convert.ToDouble(Console.ReadLine());
        double maturityAmount = principal * Math.Pow((1 + rate / 100), time);
        Console.WriteLine($"Maturity amount after {time} years: {maturityAmount}");
    }
    public void creditCardReward()
    {
        Console.Write("total credit card spending:");
        double spending = Convert.ToDouble(Console.ReadLine());
        int points = (int)(spending / 100);
            Console.WriteLine($"Reward points earned: {points}");

    }
    public void employeeBonus()
    {
        Console.Write("enter annual salary:");
        double annualSalary = Convert.ToDouble(Console.ReadLine());
        Console.Write("ENTER THE YEAR OF SERVICE:");
        int yearofService = Convert.ToInt32(Console.ReadLine()); 
        if (annualSalary >= 50000 && yearofService >= 3)
        {
           
            Console.WriteLine($"Employee is eligible for bonus");
        }
        else
        {
            Console.WriteLine("No bonus awarded.");
        }
    }

}
//

// class Program
// {
//     static void Main()
//     {
//         debitCard debit = new debitCard();
//         creditCard credit = new creditCard();
//         int choice;

//         do
//         {
//             Console.WriteLine("\n-- Banking Services Menu --");
//             Console.WriteLine("1. Debit Operations");
//             Console.WriteLine("2. Credit Operations");
//             Console.WriteLine("3. Exit");
//             Console.Write("ENTER YOUR CHOICE: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("\n-- Debit Card Management --");
//                     Console.WriteLine("1. ATM Withdrawal");
//                     Console.WriteLine("2. EMI Burden Check");
//                     Console.WriteLine("3. Daily Spending Calculator");
//                     Console.WriteLine("4. Minimum Balance Check");
//                     Console.Write("ENTER YOUR CHOICE: ");
//                     int debitChoice = Convert.ToInt32(Console.ReadLine());

//                     switch (debitChoice)
//                     {
//                         case 1: debit.atmwithdrawl(); break;
//                         case 2: debit.emiBurden(); break;
//                         case 3: debit.dailySpendingCalculator(); break;
//                         case 4: debit.minimumbalance(); break;
//                         default: Console.WriteLine("Invalid choice for Debit Operations."); break;
//                     }
//                     break;

//                 case 2:
//                     Console.WriteLine("\n-- Credit Card Management --");
//                     Console.WriteLine("1. Credit Limit Check");
//                     Console.WriteLine("2. Maturity Amount");
//                     Console.WriteLine("3. Reward Points Calculation");
//                     Console.WriteLine("4. Employee Bonus");
//                     Console.Write("ENTER YOUR CHOICE: ");
//                     int creditChoice = Convert.ToInt32(Console.ReadLine());

//                     switch (creditChoice)
//                     {
//                         case 1: credit.netsalarycredit(); break;
//                         case 2: credit.maturityAmount(); break;
//                         case 3: credit.creditCardReward(); break;
//                         case 4: credit.employeeBonus(); break;
//                         default: Console.WriteLine("Invalid choice for Credit Operations."); break;
//                     }
//                     break;

//                 case 3:
//                     Console.WriteLine("Exiting the program. Goodbye!");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }

//         } while (choice != 3);
//     }
// }