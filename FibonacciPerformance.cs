namespace ConsoleApp1;

using System;
using System.Diagnostics;

class FibonacciPerformance
{
    static void Main()
    {
        int n = 40;
        // fibonacci using recursion
        Stopwatch sw = new Stopwatch();
        sw.Start();
        int fibRec = FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine($"Recursive Fibonacci({n}): {fibRec}, Time: {sw.ElapsedMilliseconds} ms");

        // fibonaci using iterative
        sw.Restart();
        int fibIter = FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine($"Iterative Fibonacci({n}): {fibIter}, Time: {sw.ElapsedMilliseconds} ms");
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
