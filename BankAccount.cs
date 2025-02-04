using System;
class BankAccount{
    // initializing variables
    private string accountHolderName;
    private readonly long accountNumber;
    public static string bankName="SBI";
    private static int totalAccounts=0;
   
    // constructor for Bank Account
    public BankAccount(string accountHolderName,long accountNumber){
        this.accountHolderName=accountHolderName;
        this.accountNumber=accountNumber;
        totalAccounts++;
    }
     // method to get total accounts
   
    public static void GetTotalAccounts(){
        Console.WriteLine("The total numbers of account are: {0}", totalAccounts);
    }
     // method to display the details of bank account
    public void DisplayAccountDetails(){
        if(this is BankAccount){
            Console.WriteLine("Bank Name is :{0}", bankName);
            Console.WriteLine("Account Holder Name is :{0}", accountHolderName);
            Console.WriteLine("Account Number is :{0}", accountNumber);
		}
        else{
            Console.WriteLine("Not a Bank account in this Bank");
        }
    }
}
class Program{
    static void Main(string[] args){
        BankAccount acc1= new BankAccount("Michael Jordan",999);
        BankAccount acc2= new BankAccount("Calvin Harris",131);
        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();
        // displaying total number of accounts
        BankAccount.GetTotalAccounts();
		}
}
