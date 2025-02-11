using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2;

public class LinkedList
{
    class Node
    {
        private Node next;
        private int value;

        public Node(int value)
        {
            this.next = null;
            this.value = value;
        }

        public int Value
        {
            get{ return this.value; }
            set { this.value = value; }
        }
        
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; } // Should be `this.next = value;` but mistakenly written as `this.next = next;`
        }

    }
    
    private Node head;

    public void InsertLast(int value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            return;
        }
        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = node;

    }

    public void InsertFirst(int value)
    {
        Node node = new Node(value);
        node.Next = head;
        head = node;
        return;
    }

    public void InsertIndex(int index, int value)
    {
        if (index == 0)
        {
            InsertFirst(value);
        }
        int pointer = 0;
        Node temp = head;
        while ((pointer + 1) != index)
        {
            temp = temp.Next;
            pointer++;
        }
        Node node = new Node(value);
        node.Next = temp.Next;
        temp.Next = node;
    }

    public int DeleteLast()
    {
        if (head == null)
        {
            return -1;
        }
        int deleteValue = head.Value;
        if (head.Next == null)
        {
            deleteValue = head.Value;
            head = null;
            return deleteValue;
        }
        Node temp = head;
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }
        deleteValue = temp.Next.Value;
        temp.Next = null;
        return deleteValue;
    }

    public int Delete(int value)
    {
        if (head == null)
        {
            return -1; // Empty list
        }

        if (head.Value == value) // If head node holds the value
        {
            return DeleteFirst();
        }

        Node temp = head;
        Node prev = null;

        while (temp.Next != null && temp.Next.Value != value)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            return -1; // Value not found
        }

        int deleteValue = temp.Next.Value;
        temp.Next = temp.Next.Next;
        return deleteValue;
        
    }

    public int DeleteFirst()
    {
        if (head == null)
        {
            return -1;
        }
        int deleteValue = head.Value;
        if (head.Next == null)
        {
            deleteValue = head.Value;
            head = null;
            return deleteValue;
        }
        head = head.Next;
        return deleteValue;
    }

    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Value + "--->");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}