namespace ConsoleApp2;

class LinkedList
{
    class Node
    {
        public Node next;
        public int rollNumber;
        public string name;
        public int age;
        public string grades;

        public Node(int rollNumber, string name, int age, string grades)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grades = grades;
            this.next = null;
        }
    }

    private Node head;

    public void InsertRecordBeggining(int rollNumber, string name, int age, string grades)
    {
        Node node = new Node(rollNumber, name, age, grades);
        if (head == null)
        {
            head = node;
            return;
        }
        node.next = head;
        head = node;
        
    }

    public void InsertRecordEnding(int rollNumber, string name, int age, string grades)
    {
        Node node = new Node(rollNumber, name, age, grades);

        if (head == null)
        {
            head = node;
            return;
        }
        Node temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = node;
        
    }

    public void InsertRecordIndex(int index, int rollNumber, string name, int age, string grades)
    {
        Node node = new Node(rollNumber, name, age, grades);
        if (head == null)
        {
            head = node;
        }

        if (index == 1)
        {
            InsertRecordBeggining(rollNumber, name, age, grades);
            return;
        }
        int currentIndex = 1;
        Node temp = head;
        while (currentIndex + 1 < index)
        {
            temp = temp.next;
            currentIndex++;
        }
        node.next = temp.next;
        temp.next = node;
    }

    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            return;
        }

        if (head.rollNumber == rollNumber)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        while (temp.next.rollNumber != rollNumber)
        {
            temp = temp.next;
        }
        temp.next = temp.next.next;
    }

    public void UpdateGrades(int rollNumber, string newGrades)
    {
        Node temp = head;
        while (temp.rollNumber != rollNumber)
        {
            temp = temp.next;
        }
        temp.grades = newGrades;
    }

    public void SearchByRollNumber(int rollNumber)
    {
        Node temp = head;
        while (temp.rollNumber != rollNumber)
        {
            temp = temp.next;
        }
        Console.WriteLine($"student name: {temp.name}, roll number: {temp.rollNumber}, age: {temp.age}, grades: {temp.grades}");
    }

    public void DisplayAllRecords()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"student name: {temp.name}, roll number: {temp.rollNumber}, age: {temp.age}, grades: {temp.grades} ");
            temp = temp.next;
        }
    }
}

class StudentRecordManagement
{
    public static void Main(string[] args)
    {
        LinkedList studentList = new LinkedList();
        studentList.InsertRecordBeggining(777, "James Bond", 48, "A+");
        studentList.InsertRecordEnding(969, "Shrey Bhardwaj", 22, "B++");
        studentList.InsertRecordEnding(548, "Sisna Gaur", 21, "A++");
        studentList.InsertRecordEnding(12, "Bruce Wayne", 45, "A+");
        studentList.InsertRecordEnding(67, "Ted Mosby", 32, "C+");
        studentList.InsertRecordIndex(3, 888, "Optimus Prime", 138, "A++");
        studentList.DisplayAllRecords();
        Console.WriteLine("record after deleting a student");
        studentList.DeleteByRollNumber(888);
        studentList.DisplayAllRecords();
        Console.WriteLine("displaying student record by rollnumber");
        studentList.SearchByRollNumber(777);
        Console.WriteLine("updating student grades by rollnumber");
        studentList.UpdateGrades(67, "B+");
        studentList.SearchByRollNumber(67);





    }
}
