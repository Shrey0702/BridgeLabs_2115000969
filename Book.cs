namespace ConsoleApp1;

class Book
{
    
        private string title;
        private string author;
        private double price;
        // creating non parameterized constructor
        public Book()
        {
            title = "New Book";
            author = "Not Mentioned";
            price = 0.0;
        }
        // creating parameterized constructor
        public Book(string title, string author, double price)
        {
            this.title = title; 
            this.author = author;
            this.price = price;
        }

        public static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("The Lord Of The Rings", "JRR Tolkien", 29.9);
            // displaying the information of book1
            Console.WriteLine("the title of the book is {0}, the author of the book is {1} and the price of the book is {2}", book1.title, book1.author, book1.price);
            // displaying the information of book2
            Console.WriteLine("the title of the book is {0}, the author of the book is {1} and the price of the book is {2}", book2.title, book2.author, book2.price);
        }
}

