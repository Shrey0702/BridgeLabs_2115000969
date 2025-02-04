using System;
namespace LibraryManagementSystem{
    class Book{
        // initializing variables
        public static string  libraryName="Capgemini Library";
        private string Title,Author;
        private readonly string ISBN;
        //method to display library name
        public static void DisplayLibraryName(){
            Console.WriteLine("Library name is {0}", libraryName);
        }
        // parameterized constructor
        public Book(string title,string author,string ISBN){
            this.Title= title;
            this.Author=author;
            this.ISBN= ISBN;

        }
        // method to Display the book Details
        public void DisplayBookDetails(){
            if(this is Book){
                DisplayLibraryName();
                Console.WriteLine("The Title is: {0}", Title);
                Console.WriteLine("The Author is : {0}", Author);
                Console.WriteLine("The ISBN is : {0}", ISBN);
            }
        }
    }
    class Program{
        static void Main(string[] args){
            // making instance of Book
            Book book1 =new Book("Harry Potter","J K Rowling","HAR012");
            Book book2 = new Book("The Lord Of The Rings","JRR Tolkein","LOR007");
            //calling Display method
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }
    }
}
