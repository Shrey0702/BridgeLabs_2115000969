using System;
public class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;
    public BankAccount(string accountNumber, string accountHolder, double balance)
	{
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    // public methods to access and modify balance
    public double GetBalance()
	{
        return balance;
    }
    public void Deposit(double amount)
	{
        balance += amount;
    }
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance) { }

    public void DisplayAccountInfo()
	{
        Console.WriteLine("Account Number: " + accountNumber); // accessing public member
        Console.WriteLine("Account Holder: " + accountHolder); // accessing protected member
        Console.WriteLine("Balance: "+ GetBalance()); //getting  Balance
    }
	static void Main(string[] args)
	{
        SavingsAccount savingsAccount = new SavingsAccount("IOBG09989", "Shrey Bardwaj", 7777);
        savingsAccount.DisplayAccountInfo();
        savingsAccount.Deposit(1000);
        Console.WriteLine("New Balance: " + savingsAccount.GetBalance());
    }
}


