using System;

class CalculateFinalPrice{
    static void CalculateTotalPrice(double unitPrice, int quantity){
        // Calculating total price
        double totalPrice = unitPrice * quantity;

        // Printing results
        Console.WriteLine("The total purchase price is INR {0} if the quantity is {1} and unit price is INR {2}", totalPrice, quantity, unitPrice);
    }

    static void Main(){
        Console.Write("Enter the unit price of the item : ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = int.Parse(Console.ReadLine());

        CalculateTotalPrice(unitPrice, quantity);
    }
}
