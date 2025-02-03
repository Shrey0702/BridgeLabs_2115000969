namespace ConsoleApp1;

public class BankAccount
{
    static string bankName = "American Express";
    // created readonly variable
    private readonly int accountNumber;
    private string accountHolderName;
    static int totalAccounts;

// parameterized constructor
    BankAccount(string accountHolderName, int accountNumber)
    {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        // increasing total accounts whenever a new account is created
        totalAccounts++;
    }
// display total accounts method
    static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    public static void DisplayDetails(BankAccount account)
    {
        // checking if account is instance of BankAccount
        if (account is BankAccount)
        {
            Console.WriteLine("the account holder name is: {0} and the account number: {1} in Bank: {2}", account.accountHolderName, account.accountNumber, bankName);
        }
        else
        {
            Console.WriteLine("sorry no account exist");
        }
    }

    public static void Main(string[] args)
    {
        // creating account object
        BankAccount account1 = new BankAccount("Calvin Harris", 19990876);
        BankAccount account2 = new BankAccount("David Guetta", 893873);
        DisplayDetails(account1);
        DisplayDetails(account2);
        Console.WriteLine("Total Accounts: {0}", GetTotalAccounts());
        // DisplayDetails(account3);
    }
}