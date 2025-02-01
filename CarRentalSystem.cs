namespace ConsoleApp1;

public class CarRentalSystem
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private int perDayRent = 900; // creating this variable to calculate total cost
    private int totalCost;

    public CarRentalSystem(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        totalCost = perDayRent * rentalDays; 
    }

    public static void Main(string[] args)
    {
        CarRentalSystem car1 = new CarRentalSystem("Batman", "BatMobile", 07);
        CarRentalSystem car2 = new CarRentalSystem("James Bond", "Aston MArtin DB 12", 10);
        CarRentalSystem car3 = new CarRentalSystem("Max Verstappen", "Paninfarina Battista", 21);
        Console.WriteLine("the customer: {0} took car: {1} for: {2} days for total cost: {3}", car1.customerName, car1.carModel, car1.rentalDays, car1.totalCost);
        Console.WriteLine("the customer: {0} took car {1} for: {2} days for total cost: {3}", car2.customerName, car2.carModel, car2.rentalDays, car2.totalCost);
        Console.WriteLine("the customer: {0} took car {1} for: {2} days for total cost: {3}", car3.customerName, car3.carModel, car3.rentalDays, car3.totalCost);
        
    }
     
}