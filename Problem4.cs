using System;
class Book{
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public Book(string title, int publicationyear){
        Title = title;
        PublicationYear = publicationyear;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine("Title: {0}", Title);
        Console.WriteLine("Publication Year: {0}", PublicationYear);
    }
}
class Author : Book{
    public string AuthorName { get; set; }
    public string Bio { get; set; }
    public Author(string title, int publicationyear, string authorname, string bio) : base(title, publicationyear){
        AuthorName = authorname;
        Bio = bio;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Author Name: {0}", AuthorName);
        Console.WriteLine("Bio: {0}", Bio);
    }
}
class Problem4{
    public static void Main(string[]args){
        Book book = new Book("The Name of the Wind", 2007);
        Author author = new Author("The name of the wind", 2007, "Patrick Rothfuss", "No bio");
        book.DisplayInfo();
        author.DisplayInfo();
    }
}