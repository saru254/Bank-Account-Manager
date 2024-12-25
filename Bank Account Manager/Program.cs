using System;

class BankAccount
{
    private string accountNumber;
    private double balance;

    // Constructor to initialize the account
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    // Method to get the current balance
    public double GetBalance()
    {
        return balance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. Remaining balance: {balance}");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a bank account
        BankAccount myAccount = new BankAccount("123456789", 1000);

        // Display initial balance
        Console.WriteLine($"Initial balance: {myAccount.GetBalance()}");

        // Deposit money
        myAccount.Deposit(500);

        // Try withdrawing money
        myAccount.Withdraw(200);

        // Try withdrawing more than available balance
        myAccount.Withdraw(2000);

        // Display final balance
        Console.WriteLine($"Final balance: {myAccount.GetBalance()}");
    }
}
