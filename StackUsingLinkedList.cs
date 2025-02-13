/*namespace ConsoleApp1;

class StackNode
{
    public StackNode next;
    public int value;

    public StackNode(int value)
    {
        this.next = null;
        this.value = value;
    }
}

class Stack
{
    private StackNode head;

    public void push(int value)
    {
        StackNode node = new StackNode(value);
        if (head == null)
        {
            head = node;
            return;
        }
        node.next = head;
        head = node;
    }

    public int pop()
    {
        if (head == null)
        {
            return -1;
        }
        int returnValue = head.value;
        head = head.next;
        return returnValue;
    }

    public int peek()
    {
        if (head == null)
        {
            return -1;
        }
        return head.value;
    }

    public bool count()
    {
        if (head == null)
        {
            return true;
        }
        return false;
    }
}

public class StackUsingLinkedList
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.push(34);
        stack.push(56);
        stack.push(67);
        stack.push(73);
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.pop());
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.pop());
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.count());
    }
    
}*/