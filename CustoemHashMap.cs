using System;

class CustomHashMap
{
    private class Node
    {
        public int Key;
        public int Value;
        public Node Next;
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private const int SIZE = 1000; 
    private Node[] buckets;

    public CustomHashMap()
    {
        buckets = new Node[SIZE];
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key) % SIZE; // Hash function
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        Node head = buckets[index];

        // If key exists, update it
        Node current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }

        // Insert at the beginning of the linked list (chaining)
        Node newNode = new Node(key, value);
        newNode.Next = head;
        buckets[index] = newNode;
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        Node current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }

        return -1; // Key not found
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);
        Node current = buckets[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    buckets[index] = current.Next; // Remove head node
                else
                    prev.Next = current.Next; // Remove middle or last node

                return;
            }
            prev = current;
            current = current.Next;
        }
    }

    public static void Main()
    {
        CustomHashMap hashMap = new CustomHashMap();
        hashMap.Put(1, 12);
        hashMap.Put(2, 22);
        hashMap.Put(1, 17); // updating key

        Console.WriteLine("Key 1: " + hashMap.Get(1)); 
        Console.WriteLine("Key 2: " + hashMap.Get(2)); 
        Console.WriteLine("Key 3: " + hashMap.Get(3));

        hashMap.Remove(2);
        Console.WriteLine("Key 2 after deletion: " + hashMap.Get(2)); 
    }
}
