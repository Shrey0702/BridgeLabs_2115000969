namespace ConsoleApp2;

using System;

class Book{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int bookID, bool isAvailable){
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class Library{
    private Book head;
    private Book tail;

    public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable){
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if(head == null){
            head = tail = newBook;
            return;
        }
        tail.Next = newBook;
        newBook.Prev = tail;
        tail = newBook;
    }

    public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable){
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null){
            head = tail = newBook;
            return;
        }
        newBook.Next = head;
        head.Prev = newBook;
        head = newBook;
    }

    public void AddBookAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position){
        if(position == 1){
            AddBookAtBeginning(title, author, genre, bookID, isAvailable);
            return;
        }
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        Book temp = head;
        for(int i= 1; temp != null && i< position-1; i++){
            temp = temp.Next;
        }
        if(temp == null){
            Console.WriteLine("Invalid position.");
            return;
        }
        newBook.Next = temp.Next;
        if (temp.Next != null)
        {
            temp.Next.Prev = newBook;
        }
        temp.Next = newBook;
        newBook.Prev = temp;
    }

    public void RemoveBook(int bookID)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }
        if(temp == null){
            Console.WriteLine("Book not found.");
            return;
        }
        if(temp == head){
            head = temp.Next;
        }
        if(temp == tail){
            tail = temp.Prev;
        }
        if(temp.Prev != null){
            temp.Prev.Next = temp.Next;
        }
        if(temp.Next != null){
            temp.Next.Prev = temp.Prev;
        }
        Console.WriteLine("Book removed successfully.");
    }

    public Book SearchBookByTitle(string title){
        Book temp = head;
        while (temp != null){
            if (temp.Title == title){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Book SearchBookByAuthor(string author){
        Book temp = head;
        while (temp != null){
            if (temp.Author == author){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateAvailabilityStatus(int bookID, bool newStatus)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = newStatus;
                Console.WriteLine("Availability status updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void DisplayBooksForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine("Book ID: " + temp.BookID + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + (temp.IsAvailable ? "Yes" : "No"));
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine("Book ID: " + temp.BookID + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + (temp.IsAvailable ? "Yes" : "No"));
            temp = temp.Prev;
        }
    }

    public int CountTotalBooks()
    {
        int count = 0;
        Book temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
}

class LibraryManagementSystem{
    public static void Main(string[] args){
        Library library = new Library();

        library.AddBookAtEnd("48 Laws Of Power", "Robert Greene", "Psycology", 101, true);
        library.AddBookAtEnd("To Kill a Mockingbird", "Harper Lee", "Fiction", 102, true);
        library.AddBookAtBeginning("1984", "George Orwell", "Dystopian", 103, false);
        library.AddBookAtPosition("The Name of The Wind", "Patrick Rothfuss", "Fiction", 104, true, 2);

        Console.WriteLine("Library Books (Forward Order):");
        library.DisplayBooksForward();

        Console.WriteLine("Library Books (Reverse Order):");
        library.DisplayBooksReverse();

        Console.WriteLine("Searching for Book by Title (1984):");
        Book foundBook = library.SearchBookByTitle("1984");
        if (foundBook != null)
            Console.WriteLine("Found: " + foundBook.Title + " by " + foundBook.Author);
        else
            Console.WriteLine("Book not found.");

        Console.WriteLine("Updating Availability Status for Book ID 101:");
        library.UpdateAvailabilityStatus(101, false);

        Console.WriteLine("Removing Book ID 102:");
        library.RemoveBook(102);

        Console.WriteLine("Total Books in Library: " + library.CountTotalBooks());

        Console.WriteLine("Updated Library Books:");
        library.DisplayBooksForward();
    }
}
