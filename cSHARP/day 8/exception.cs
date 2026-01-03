using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Withdrawal amount must be greater than zero."
            );
        }

        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient balance.");
        }

        Balance -= amount;
    }
}



