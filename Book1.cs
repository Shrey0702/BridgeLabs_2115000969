using System;
public class Book1{
    public string ISBN;
    protected string title;
    private string author;

    public Book1(string ISBN, string title, string author)
	{
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // puvlic getters and setters
    public string GetAuthor()
	{
        return author;
    }

    public void SetAuthor(string author)
	{
        this.author = author;
    }
}
// inheriting book
public class EBook : Book1
{
    public EBook(string ISBN, string title, string author)
        : base(ISBN, title, author) { }

    public void DisplayBookInfo()
	{
        Console.WriteLine("ISBN: " + ISBN); // Accessing public member
        Console.WriteLine("Title: " + title); // Accessing protected member
    }
	
	static void Main(string[] args)
	{
        EBook ebook = new EBook("293-676-679", "Pro C#", "Andrew Toelsen");
        ebook.DisplayBookInfo();
        Console.WriteLine("Author: " + ebook.GetAuthor());
    }
}


