namespace DefaultNamespace;

using System;
using System.Collections.Generic;
abstract class Product{
    public string Name { get; set; }
    public double Price { get; set; }
    public Product(string name, double price){
        Name = name;
        Price = price;
    }
    public abstract void Display();
}
class BookCategory : Product{
    public string Author { get; set; }
    public BookCategory(string name, string author, double price): base(name, price){
        Author = author;
    }
    public override void Display(){
        Console.WriteLine($"BookName: {Name}, Author: {Author}, Price: {Price:C}");
    }
}
class ClothingCategory : Product{
    public string Seller { get; set; }
    public ClothingCategory(string name, string seller, double price): base(name, price){
        Seller = seller;
    }
    public override void Display(){
        Console.WriteLine($"Clothing: {Name}, Seller: {Seller}, Price: {Price:C}");
    }
}
class ProductList<T> where T : Product{
    private List<T> products = new List<T>();
    public void AddProduct(T product){
        products.Add(product);
    }
    public void ApplyDiscount<TProduct>(TProduct product, double discount) where TProduct: Product{
        product.Price -= product.Price * (discount / 100);
        Console.WriteLine($"Discount of {discount}% applied on {product.Name} so new Price: ₹{product.Price}");
    }
    public void DisplayInfo(){
        foreach (var product in products){
            product.Display();
        }
    }
}
class MarketPlace{
    static void Main(){
        ProductList<BookCategory> books = new ProductList<BookCategory>();
        ProductList<ClothingCategory> clothings = new ProductList<ClothingCategory>();
        var book1 = new BookCategory("Harry Potter", "J.K. Rowling", 800);
        var book2 = new BookCategory("The Lord of The RIngs", "JRR Tolkien", 1100);
        books.AddProduct(book1);
        books.AddProduct(book2);

        var cloth1 = new ClothingCategory("Pants", "Peter England", 2900);
        var cloth2 = new ClothingCategory("T-Shirt", "Ralph Lauren", 1700);
        clothings.AddProduct(cloth1);
        clothings.AddProduct(cloth2);
        books.DisplayInfo();
        Console.WriteLine();
        clothings.DisplayInfo();
        Console.WriteLine();
        books.ApplyDiscount(book1, 10);
        clothings.ApplyDiscount(cloth1, 20);
        Console.WriteLine();
        books.DisplayInfo();
        Console.WriteLine();
        clothings.DisplayInfo();
    }
}


