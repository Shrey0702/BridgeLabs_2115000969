using System;

class EmployeeBonus{
    static void CalculateBonus(int salary, int years){
        if(years > 5){
			double bonus = salary * 0.05;  // because 5% is 5/100 i.e = 0.05
			Console.WriteLine(string.Format("The bonus amount will be {0}", bonus));
		}
		else{
			Console.WriteLine("you are not eligible for bonus");
		}
        
    }

    static void Main(){
        Console.Write("Enter your salary: ");
        int salary = int.Parse(Console.ReadLine());

        Console.Write("Enter your years of service: ");
        int years = int.Parse(Console.ReadLine());

        CalculateBonus(salary, years);
    }
}
