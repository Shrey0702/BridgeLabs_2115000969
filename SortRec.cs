using System;
using System.Collections.Generic;

class SortStackRecursively
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count <= 1)
            return;

        // popping the element
        int top = stack.Pop();

        // sorting the remaining stack
        SortStack(stack);

        InsertSorted(stack, top);
    }

    private static void InsertSorted(Stack<int> stack, int element)
    {
        // base case to stop recursion
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        int top = stack.Pop();

        InsertSorted(stack, element);

        stack.Push(top);
    }

    public static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(4);
        stack.Push(7);
        stack.Push(1);
        stack.Push(8);

        Console.WriteLine("Original Stack:");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        PrintStack(stack);
    }
}
