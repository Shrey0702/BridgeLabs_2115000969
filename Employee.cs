using System;

class Employee{
    public string name;
    public int id;
    public double salary;

    // method to display details
    public void DisplayDetails(){
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: $" + salary);
    }
}

class EmployeeDetails{
    static void Main(){
        // creating an object of Employee class
        Employee emp1 = new Employee();
        
        // assigning values
        emp1.id = 101;
        emp1.name = "John Doe";
        emp1.salary = 50000.50;

        // calling method to display details
        emp1.DisplayDetails();
    }
}
