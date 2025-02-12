namespace ConsoleApp2;

using System;

class Node
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Node Next;

    public Node(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class SinglyLinkedList
{
    private Node head;

    public void AddItemAtEnd(string itemName, int itemID, int quantity, double price)
    {
        Node newNode = new Node(itemName, itemID, quantity, price);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void AddItemAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        Node newNode = new Node(itemName, itemID, quantity, price);
        newNode.Next = head;
        head = newNode;
    }

    public void AddItemAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        if (position == 1)
        {
            AddItemAtBeginning(itemName, itemID, quantity, price);
            return;
        }
        Node newNode = new Node(itemName, itemID, quantity, price);
        Node temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }
        Node temp = head, prev = null;
        while (temp != null && temp.ItemID != itemID)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        prev.Next = temp.Next;
    }

    public Node SearchItemByID(int itemID)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Node SearchItemByName(string itemName)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateItemQuantity(int itemID, int newQuantity)
    {
        Node node = SearchItemByID(itemID);
        if (node != null)
        {
            node.Quantity = newQuantity;
            Console.WriteLine("Quantity updated successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public double CalculateTotalInventoryValue()
    {
        double totalValue = 0;
        Node temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        return totalValue;
    }

    public void SortByItemName()
    {
        if (head == null || head.Next == null) return;

        Node current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.Next)
        {
            for (index = current.Next; index != null; index = index.Next)
            {
                if (string.Compare(current.ItemName, index.ItemName) > 0)
                {
                    tempName = current.ItemName;
                    tempID = current.ItemID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.ItemName = index.ItemName;
                    current.ItemID = index.ItemID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.ItemName = tempName;
                    index.ItemID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
    }

    public void SortByPrice()
    {
        if (head == null || head.Next == null) return;

        Node current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.Next)
        {
            for (index = current.Next; index != null; index = index.Next)
            {
                if (current.Price > index.Price)
                {
                    tempName = current.ItemName;
                    tempID = current.ItemID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.ItemName = index.ItemName;
                    current.ItemID = index.ItemID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.ItemName = tempName;
                    index.ItemID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
    }

    public void DisplayAllItems()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine("Item ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }
}

class InventoryManagementSystem
{
    public static void Main()
    {
        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

        singlyLinkedList.AddItemAtEnd("Deadpool Satue", 199, 7, 99999);
        singlyLinkedList.AddItemAtEnd("Mouse", 102, 76, 34);
        singlyLinkedList.AddItemAtBeginning("Keyboard", 103, 10, 50);
        singlyLinkedList.AddItemAtPosition("Bluetooth Speaker", 107, 5, 2000, 2);

        Console.WriteLine("All Inventory Items:");
        singlyLinkedList.DisplayAllItems();

        Console.WriteLine("Total Inventory Value: $" + singlyLinkedList.CalculateTotalInventoryValue());

        Console.WriteLine("Searching for Item ID 102:");
        Node foundNode = singlyLinkedList.SearchItemByID(102);
        if (foundNode != null)
            Console.WriteLine("Found Item: " + foundNode.ItemName);
        else
            Console.WriteLine("Item not found.");

        Console.WriteLine("Updating Quantity for Item ID 101:");
        singlyLinkedList.UpdateItemQuantity(101, 10);

        Console.WriteLine("Sorting Inventory by Name:");
        singlyLinkedList.SortByItemName();
        singlyLinkedList.DisplayAllItems();

        Console.WriteLine("Sorting Inventory by Price:");
        singlyLinkedList.SortByPrice();
        singlyLinkedList.DisplayAllItems();

        Console.WriteLine("Removing Item ID 102:");
        singlyLinkedList.RemoveItem(102);

        Console.WriteLine("Updated Inventory:");
        singlyLinkedList.DisplayAllItems();
    }
}
