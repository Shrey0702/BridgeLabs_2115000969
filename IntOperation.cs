using System;

class IntOperation{
    static void PerformIntOperations(int a, int b, int c){
        // calculating integer operations
		// points -- presedence is left to right for same level operators
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        Console.WriteLine(string.Format("The results of Int Operations are: {0}, {1}, {2}, and {3}", result1, result2, result3, result4));
    }

    static void Main(){
        Console.Write("Enter the value of a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = int.Parse(Console.ReadLine());

        PerformIntOperations(a, b, c);
    }
}
