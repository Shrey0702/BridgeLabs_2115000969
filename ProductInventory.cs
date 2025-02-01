namespace ConsoleApp1;

public class ProductInventory
{
    // creating a global variable using static keyword
    static int totalProducts;
    private string productName;
    private double price;
// created parameterized constrcutor
    public ProductInventory(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++; // totalProducts++ will count the total products independent of any object
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("the product is: {0} and it's price is {1}", this.productName, this.price);
    }
// static method to show total products
    public static int DisplayTotalProducts()
    {
        return totalProducts;
    }

    public static void Main(string[] args)
    {
        ProductInventory maggi = new ProductInventory("Maggi", 50);
        ProductInventory oil = new ProductInventory("Oil", 90);
        ProductInventory oreo =  new ProductInventory("oreo", 30);
        ProductInventory ketchup = new ProductInventory("Ketchup", 110);
        maggi.DisplayProductDetails();
        oreo.DisplayProductDetails();
        ketchup.DisplayProductDetails();
        oil.DisplayProductDetails();
        Console.WriteLine("the total products available is: {0}", DisplayTotalProducts());
        
    }
}