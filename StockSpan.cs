using System;
using System.Collections.Generic;

class StockSpanProblem
{
    public static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>(); 

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                stack.Pop();

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            stack.Push(i);
        }

        return span;
    }

    public static void Main()
    {
        int[] prices = { 12,43,65,2,42,432,2,42,777 };

        int[] span = CalculateStockSpan(prices);

        Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
        Console.WriteLine("Span Values:  " + string.Join(", ", span));
    }
}
