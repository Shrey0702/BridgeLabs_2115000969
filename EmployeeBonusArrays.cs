using System;

class EmployeeBonusArrays{
    public static void Main(){
        const int employeeCount = 10; // number of employees
        double[] salaries = new double[employeeCount]; // array for employee salaries
        double[] yearsOfService = new double[employeeCount]; // array for years of service
        double[] bonuses = new double[employeeCount]; // array for bonuse
        double[] newSalaries = new double[employeeCount]; // array for new salaries

        double totalBonus = 0; // total bonus payout
        double totalOldSalary = 0; // total old salary
        double totalNewSalary = 0; // yotal new salary

        // taking user input
        for (int i = 0; i < employeeCount; i++){
            Console.WriteLine("Enter details for Employee {0}: ", i + 1);

            // using while loop so that no invalid salary is added to our array
            while (true){
                Console.Write("Enter Salary: ");
                try{  // used try block to validate the input salary
                    salaries[i] = double.Parse(Console.ReadLine());
                    if (salaries[i] <= 0){
                        Console.WriteLine("Salary must be greater than 0. Please try again.");
                        continue;
                    }
                    totalOldSalary += salaries[i]; // adding to total old salary
                    break;  // used to get out of infinite loop
                }
                catch{  // if the salary is invalid then ask user to fill again
                    Console.WriteLine("Invalid input. Please enter valid salary amount");
                }
            }

            // using while loop so that no invalid years pf service is added to our array
            while (true){
                Console.Write("Enter Years of Service: ");
                try{  // used try block to validate the giver years of service
                    yearsOfService[i] = double.Parse(Console.ReadLine());
                    if (yearsOfService[i] < 0){
                        Console.WriteLine("Years of service must be 0 or more. Please try again.");
                        continue;
                    }
                    break;  // will break the loop if years of service is valid
                }
                catch{
                    Console.WriteLine("Invalid input. Please enter valid years of service");
                }
            }
        }

        // calculating bonuses, new salaries, and totals
        for (int i = 0; i < employeeCount; i++){
            // calculating bonus percentage based on years of service
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;

            // calculating bonus and new salary
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            // adding to total bonus and total new salary
            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        // displaying results
        for (int i = 0; i < employeeCount; i++){
            Console.WriteLine("Employee {0}: Old Salary = {1}, Bonus = {2}, New Salary = {3}",i + 1, salaries[i], bonuses[i], newSalaries[i]);
        }
		// writing extra details which we calculated
        Console.WriteLine("Total Old Salary: {0}", totalOldSalary);
        Console.WriteLine("Total Bonus Payout: {0}", totalBonus);
        Console.WriteLine("Total New Salary: {0}", totalNewSalary);
    }
}
