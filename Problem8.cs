using System;
class BankAccount{
    protected int AccountNumber { get; set; }
    protected double Balance { get; set; }
    public BankAccount(int accountnumber, double balance){
        AccountNumber = accountnumber;
        Balance = balance;
    }
    public virtual void DisplayAccountInfo(){
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
    public virtual void DisplayAccountType(){
        Console.WriteLine("Account Type: Normal Bank Account");
    }
}
class SavingsAccount : BankAccount{
    public double InterestRate { get; set; }
    public SavingsAccount(int accountnumber, double balance, double interestrate) : base(accountnumber, balance){
        InterestRate = interestrate;
    }
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Interest Rate: {InterestRate}%\n");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Savings Account");
    }
}
class CheckingAccount : BankAccount{
    public double WithdrawalLimit { get; set; }
    public CheckingAccount(int accountnumber, double balance, double withdrawallimit) : base(accountnumber, balance){
        WithdrawalLimit = withdrawallimit;
    }
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Withdrawal Limit: {WithdrawalLimit:C}\n");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Checking Account");
    }
}
class FixedDepositAccount : BankAccount{
    public int Term { get; set; }
    public FixedDepositAccount(int accountnumber, double balance, int term) : base(accountnumber, balance){
        Term = term;
    }
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Term: {Term} months\n");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Fixed Deposit Account");
    }
}
class Problem8{
    public static void Main(string[] args){
        BankAccount[] accounts = new BankAccount[3];
        accounts[0] = new SavingsAccount(10000000, 5000, 5);
        accounts[1] = new CheckingAccount(10000001, 10000, 1000);
        accounts[2] = new FixedDepositAccount(10000002, 20000, 12);
        foreach(BankAccount account in accounts){
            account.DisplayAccountType();
            account.DisplayAccountInfo();
        }
    }
}
