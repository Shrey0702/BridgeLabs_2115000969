namespace ConsoleApp2;

class CircularLinkedList
{
    class Node
    {
        public Node next;
        public int taskID;
        public string taskName;
        public string priority;
        public string dueDate;

        public Node(int taskID, string taskName, string priority, string dueDate)
        {
            this.next = null;
            this.taskID = taskID;
            this.taskName = taskName;
            this.priority = priority;
            this.dueDate = dueDate;
        }
    }
    
    private Node head;

    public void InsertAtEnd(int taskID, string taskName, string priority, string dueDate)
    {
        Node node = new Node(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = node;                                                                                                                   
            head.next = head;
            return;
        }
        Node temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        temp.next = node;
        node.next = head;
    }

    public void InsertAtStart(int taskID, string taskName, string priority, string dueDate)
    {
        Node node = new Node(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = node;
            head.next = head;
            return;
        }
        Node temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }

        node.next = head;
        head = node;
        temp.next = head;
        
        
    }

    public void InsertAtIndex(int index, int taskID, string taskName, string priority, string dueDate)
    {
        Node node = new Node(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = node;
            head.next = head;
            return;
        }

        if (index == 1)
        {
            InsertAtStart(taskID, taskName, priority, dueDate);
            return;
        }
        int currentIndex = 1;
        Node temp = head;
        while (currentIndex + 1 < index)
        {
            temp = temp.next;
            currentIndex++;
        }

        if (temp.next == head)
        {
            InsertAtEnd(taskID, taskName, priority, dueDate);
            return;
        }
        node.next = temp.next;
        temp.next = node;
        
    }

    public void RemoveByID(int taskID)
    {
        if (head == null)
        {
            return;
        }
        
        // for deleting at beggining case
        if (head.taskID == taskID)
        {
            Node temp1 = head;
            head = head.next;
            while (temp1.next != head)
            {
                temp1 = temp1.next;
            }

            temp1.next = head;
        }
        Node temp = head;

        while (temp.next.taskID != taskID)
        {
            temp = temp.next;
        }
        // for deleting last node
        if (temp.next.next == head)
        {
            temp.next.next = null;
            temp.next = head;
            return;
        }
        temp.next = temp.next.next;
        
    }

    public void DisplayAllTasks()
    {
        Node temp = head;
        while (temp.next != head)
        {
            Console.WriteLine($"Task id: {temp.taskID}, task name: {temp.taskName}, priority: {temp.priority}, dueDate: {temp.dueDate}");
            temp = temp.next;
        }
        Console.WriteLine($"Task id: {temp.taskID}, task name: {temp.taskName}, priority: {temp.priority}, dueDate: {temp.dueDate}");
    }

    public void SearchTaskByPriority(string taskPriority)
    {
        Node temp = head;
        while (temp.priority != taskPriority)
        {
            temp = temp.next;
        }
        Console.WriteLine($"Task id: {temp.taskID}, task name: {temp.taskName}, priority: {temp.priority}, dueDate: {temp.dueDate}");

    }
}


public class TaskScheduler
{
    public static void Main(string[] args)
    {
        CircularLinkedList circularLinkedList = new CircularLinkedList();
        circularLinkedList.InsertAtEnd(1, "brushing", "important", "14-02-2025");
        circularLinkedList.InsertAtEnd(2, "studying C#", "topmost", "15-02-2025");
        circularLinkedList.DisplayAllTasks();
        Console.WriteLine("Adding at first index");
        circularLinkedList.InsertAtStart(3, "Play Valorant", "normal", "16-02-2025");
        circularLinkedList.DisplayAllTasks();
        Console.WriteLine("Adding at particular index");
        circularLinkedList.InsertAtIndex(3, 4,"Meditation", "habit", "14-02-2025");
        circularLinkedList.DisplayAllTasks();
        Console.WriteLine("Deleting at particular index");
        circularLinkedList.RemoveByID(1);
        circularLinkedList.DisplayAllTasks();
        Console.WriteLine("Searching task by priority");
        circularLinkedList.SearchTaskByPriority("normal");
        

    }
}