using System;

public class Book{
    private string title;
    private string author;
    private double price;

// using parameterized constructor
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // method to display
    public void DisplayDetails(){
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Author: {0}", author);
        Console.WriteLine("Price: {0}", price);
    }
}

public class BookDetails{
    public static void Main(){
        Book book1 = new Book("Abra Ca Dabra", "Martin Garrix", 21.99);

        // displaying details
        Console.WriteLine("=== Book 1 details ===");
        book1.DisplayDetails();
       
    }
}
