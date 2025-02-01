namespace ConsoleApp1;

public class LibraryBookSystem
{
    private string title;
    private string author;
    private int price;
    private bool availability;

    
    // creating a constructor for initialising the vairable
    public LibraryBookSystem(string title, string author, int price)
    // it this constructor we are not writing avilabilty as a parameter because is should be true by default 
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = true;
    }
    
    // creating a borrow method
    // we will check if the given book is available or not 
    // after allocating we can change the availability to false
    
    // below we did something similar to copy function to get status of a particular book
    // we made the method static so we don't need to make a new object to borrow the book
    private static void BorrowBook(LibraryBookSystem book)
    {
        if (book.availability == false)
        {
            Console.WriteLine("sorry the book isn't available you cannot borrow this");
            return;
        }
        // if we have the book we can message that you can borrow the book
        // also we can change the availability to false
        Console.WriteLine("you can borrow the book: {0} by the author: {1} for the price: {2}", book.title, book.author,
            book.price);
        book.availability = false;
    }

    public static void Main(string[] args)
    {
        // creating book object
        LibraryBookSystem harryPotter = new LibraryBookSystem("Harry Potter and the prisoner of askaban", "JK Rowling", 1299);
        LibraryBookSystem ikigai = new LibraryBookSystem("Ikigai", "Hector Garcia and Francesc Miralles", 999);

        // now calling the borrowing function to check if it's working fine
        //book1.BorrowBook("Harry Potter and the prisoner of askaban");
        //book2.BorrowBook("Ikigai");
        // now calling borrowbook again on book one to check if it prints false
        //book2.BorrowBook("Ikigai");
        // calling borrow book to borrow the specific book if it's available we will give it to the person
        BorrowBook(harryPotter);
        BorrowBook(ikigai);
        // again trying to borrow the same book to check if it's showing error
        BorrowBook(harryPotter);

    }
}