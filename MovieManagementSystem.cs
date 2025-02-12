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
        head.prev = node;
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
            head = new Node(movieTitle, director, yearOfRelease, rating);
            tail = head;
            return;
        }

        if (index == 1)
        {
            AddMovieAtBeggining(movieTitle, director, yearOfRelease, rating);
            return;
        }
        int count = 1;
        Node temp = head;
        Node node = new Node(movieTitle, director, yearOfRelease, rating);
        while (count < index)
        {
            temp = temp.next;
            count++;
        }

        //Console.Write($"movie title: {temp.movieTitle}\n");
        Node previour = temp.prev;
        Node forward = temp;
        previour.next = node;
        forward.prev = node;
        node.prev = previour;
        node.next = forward;
       // Console.Write(temp.prev.movieTitle + "\n");
       /*Console.Write("kjdshk");
        Console.Write("movie: " + temp.movieTitle + "\n");
        Console.Write("movie" + node.movieTitle + "\n");
        Console.Write("mpvie: " + head.next.prev.movieTitle + "\n");*/


    }

    public void DeleteMovieByTitle(string movieTitle)
    {
        Node temp = head;
        while (temp.movieTitle != movieTitle)
        {
            temp = temp.next;
        }

        if (temp.prev == null)
        {
            head = temp.next;
            head.prev = null;
            temp.next = null;
            return;
        }
        else if (temp.next == null)
        {
            tail = temp.prev;
            tail.next = null;
            temp.prev = null;
            return;
        }
        // checking if there's no movies of that title
        else if (temp.movieTitle != null)
        {
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;
            temp.next = null;
            temp.prev = null;
        }
        else
        {
            Console.WriteLine("The movie title is empty");
        }
    }

    public void DisplayAllMovies()
    {
        Console.WriteLine("Movies in forward order");
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Movie name: {temp.movieTitle}, director: {temp.director}, year of release: {temp.yearOfRelease}, rating: {temp.rating}");
            temp = temp.next;
        }
        Console.WriteLine("Movies in reverse order");
        temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Movie name: {temp.movieTitle}, director: {temp.director}, year of release: {temp.yearOfRelease}, rating: {temp.rating}");
            temp = temp.prev;
        }
        

    }
// using constructor overloading to search by Rating or Director
    public void SearchByDirectorOrRating(double rating)
    {
        Node temp = head;
        while (temp.rating != rating)
        {
            temp = temp.next;
        }

        
        Console.WriteLine($"Movie name: {temp.movieTitle}, director: {temp.director}, year of release: {temp.yearOfRelease}, rating: {temp.rating}");
        
    }

    public void SearchByDirectorOrRating(string director)
    {
        Node temp = head;
        while (temp.director != director)
        {
            temp = temp.next;
        }
        Console.WriteLine($"Movie name: {temp.movieTitle}, director: {temp.director}, year of release: {temp.yearOfRelease}, rating: {temp.rating}");
    }

    public void UpdateMovieRatingByTitle(string movieTitle, double updatedRating)
    {
        Node temp = head;
        while (temp.movieTitle != movieTitle)
        {
            temp = temp.next;
        }
        temp.rating = updatedRating;
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
        Console.WriteLine("Adding movie at particular index");
        dll.AddMovieAtIndex(2, "Tamasha", "Imtiaz Ali", 2016, 7.5);
        dll.DisplayAllMovies();
        Console.WriteLine("Removing a movie using movie title");
        dll.DeleteMovieByTitle("Tamasha");
        dll.DisplayAllMovies();
        Console.WriteLine("Searching by director or rating of movie");
        dll.SearchByDirectorOrRating(8.9);
        dll.SearchByDirectorOrRating("Christopher Nolan");
        dll.DisplayAllMovies();
        Console.WriteLine("Updating movie rating");
        dll.UpdateMovieRatingByTitle("Pacific Rim", 7.5);
        dll.SearchByDirectorOrRating(7.5);
        
        
        
        
    }
}