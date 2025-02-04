using System;
namespace ShoppingCartSystem{
    class Product{
        // initialising variables
        private static double Discount=15;
        private string ProductName;
        private double Price;
        private double Quantity;
        private readonly string ProductId;
        //Update Discount Method
        public static void UpdateDiscount(double discount){
            Discount=discount;
        } 
        // method to calculate the total Price of product
        private static double CalculateTotalPrice(double price,double quantity){
            double totalPrice=price*quantity;
            double discountPrice= (Discount*totalPrice)/100;
            return totalPrice-discountPrice;
        }
        // constructor method
        public Product(string productId,string productName,double price,double quantity){
            this.ProductId=productId;
            this.ProductName=productName;
            this.Price=price;
            this.Quantity=quantity;
        }
        // method to display product details
        public void ProductDetails(){
            Console.WriteLine("The Product Id is: {0}", ProductId);
            Console.WriteLine("The Product name is: {0}", ProductName);
            Console.WriteLine("The Price of product is {0}", Price.ToString());
            Console.WriteLine("The Quantity is: {0}", Quantity);
            Console.WriteLine("The Total Price is: " +  CalculateTotalPrice(Price,Quantity).ToString());
        }

    }
    class Program{
        static void Main(string[] args){
            //make instance of product
            Product product1= new Product("PRO01","Soap",10.05,100);
            Product.UpdateDiscount(10);
            Product product2= new Product("PRO03","Laptop",97000,10);
            if (product1 is Product){
            product1.ProductDetails();}
            if (product2 is Product){
            product2.ProductDetails();}

        }
    }
}
