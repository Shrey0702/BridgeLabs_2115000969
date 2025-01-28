using System;

class ZaraBonus{
    public static void Main()
    {
        // Create a 2D array to store employee salary and years of service
        double[,] employeeData = GenerateEmployeeData();

        // Calculate the new salary and bonus based on years of service
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData);

        // Display the summary in a tabular format
        DisplaySummary(employeeData, updatedData);
    }

    // Method to generate the employee data: salary and years of service
    public static double[,] GenerateEmployeeData()
    {
        Random rand = new Random();
        double[,] employeeData = new double[10, 2]; // 10 employees, 2 columns (salary, years of service)

        for (int i = 0; i < 10; i++)
        {
            employeeData[i, 0] = rand.Next(10000, 100000); // Random 5-digit salary
            employeeData[i, 1] = rand.Next(1, 31); // Random years of service between 1 and 30
        }

        return employeeData;
    }

    // Method to calculate the new salary and bonus based on years of service
    public static double[,] CalculateBonusAndNewSalary(double[,] employeeData)
    {
        double[,] updatedData = new double[10, 3]; // 10 employees, 3 columns (old salary, new salary, bonus)

        for (int i = 0; i < 10; i++)
        {
            double salary = employeeData[i, 0];
            int yearsOfService = (int)employeeData[i, 1];
            double bonus = 0;

            // Bonus logic
            if (yearsOfService > 5)
            {
                bonus = salary * 0.05; // 5% bonus
            }
            else
            {
                bonus = salary * 0.02; // 2% bonus
            }

            double newSalary = salary + bonus;

            // Store old salary, new salary, and bonus in the updatedData array
            updatedData[i, 0] = salary;
            updatedData[i, 1] = newSalary;
            updatedData[i, 2] = bonus;
        }

        return updatedData;
    }

    // Method to display the summary in a tabular format
    public static void DisplaySummary(double[,] oldData, double[,] newData)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee Bonus Details:");
        Console.WriteLine("{0,-5} {1,-12} {2,-12} {3,-10} {4,-10}", "Emp#", "Old Salary", "New Salary", "Bonus", "Years of Service");

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = oldData[i, 0];
            double newSalary = newData[i, 1];
            double bonus = newData[i, 2];
            int yearsOfService = (int)oldData[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine("{0,-5} {1,-12:C} {2,-12:C} {3,-10:C} {4,-10}", i + 1, oldSalary, newSalary, bonus, yearsOfService);
        }

        // Display totals
        Console.WriteLine("\nTotal Old Salary: {0:C}", totalOldSalary);
        Console.WriteLine("Total New Salary: {0:C}", totalNewSalary);
        Console.WriteLine("Total Bonus: {0:C}", totalBonus);
    }
}
