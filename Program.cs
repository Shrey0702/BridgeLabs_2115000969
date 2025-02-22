using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        string filePath = "employees.json";
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int numEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numEmployees; i++)
        {
            Employee emp = new Employee();
            Console.Write("Enter ID: ");
            emp.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();
            Console.Write("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());
            employees.Add(emp);
        }

        string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        Console.WriteLine("Employee data saved successfully.");

        // Deserialize and display
        string jsonData = File.ReadAllText(filePath);
        List<Employee> loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonData);

        Console.WriteLine("\nDeserialized Employee Data:");
        foreach (var emp in loadedEmployees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }
}

