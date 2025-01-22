using System;

class TotalIncome{
    public static void CalculateAndPrintIncome(double salary, double bonus){
        double totalIncome = salary + bonus;
        Console.WriteLine(string.Format("The salary is INR {0} and bonus is INR {1}. Hence Total Income is INR {2}", salary, bonus, totalIncome));
    }

    static void Main(){
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        CalculateAndPrintIncome(salary, bonus);
    }
}
