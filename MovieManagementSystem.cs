namespace ConsoleApp2;

class DoublyLinkedList
{
    
    class Node
    {
        public Node next;
        public Node prev;
        public string movieTitle;
        public string director;
        public int yearOfRelease;
        public double rating;

        public Node(string movieTitle, string director, int yearOfRelease, double rating)
        {
            this.movieTitle = movieTitle;
            this.director = director;
            this.yearOfRelease = yearOfRelease;
            this.rating = rating;
            this.next = null;
            this.prev = null;
        }
    }
    private Node head;
    private Node tail;
    public void AddMovieAtBeggining(string movieTitle, string director, int yearOfRelease, double rating)
    {
        Node node = new Node(movieTitle, director, yearOfRelease, rating);
        if (head == null)
        {
            head = node;
            tail = node;
            return;
        }
        node.next = head;
        node.prev = null;
        head = node;
    }

    public void AddMovieAtEnding(string movieTitle, string director, int yearOfRelease, double rating)
    {
        Node node = new Node(movieTitle, director, yearOfRelease, rating);

        if (head == null)
        {
            AddMovieAtBeggining(movieTitle, director, yearOfRelease, rating);
            return;
        }
        tail.next = node;
        node.prev = tail;
        node.next = null;
        tail = node;
    }

    public void AddMovieAtIndex(int index, string movieTitle, string director, int yearOfRelease, double rating)
    {
        if (head == null)
        {
            AddMovieAtBeggining(movieTitle, director, yearOfRelease, rating);
            return;
        }

        int count = 1;
        Node temp = head;
        Node node = new Node(movieTitle, director, yearOfRelease, rating);
        while (count < index || temp != null)
        {
            temp = temp.next;
        }

        if (temp != null)
        {
            node.prev = temp.prev;
            node.prev.next = node;
            node.next = temp;
            node.next.prev = node;
        }
        else
        {
            Console.WriteLine("Invalid Syntax");
        }
        
    }

    public void DisplayAllMovies()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.movieTitle);
            temp = temp.next;
        }
    }
}


class MovieManagementSystem
{
    public static void Main(string[] args)
    {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.AddMovieAtBeggining("LA LA LAND", "Damian Chazelle", 2016, 8);
        dll.AddMovieAtEnding("The Lord Of The Rings: the fellowship of the rings", "Peter Jackson", 2001, 8.9);
        dll.AddMovieAtBeggining("The Dark Knight", "Christopher Nolan", 2008, 9);
        dll.DisplayAllMovies();
        dll.AddMovieAtEnding("Pacific Rim", "Guillermo del Toro", 2013, 6.9);
        dll.DisplayAllMovies();
        dll.AddMovieAtIndex(1, "Tamasha", "abc", 2016, 7.5);
        dll.DisplayAllMovies();
        
        
        
        
    }
}