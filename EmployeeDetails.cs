using System;

class Employee{
    public string name;
    public int id;
    public double salary;

    // method to display details
    public void DisplayDetails(){
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Salary: {0}", salary);
    }
}

class EmployeeDetails{
    static void Main(){
        // creating an object of Employee class
        Employee emp1 = new Employee();
        
        // assigning values
        emp1.id = 007;
        emp1.name = "Shrey Bhardwaj";
        emp1.salary = 372893;

        // calling method to display details
        emp1.DisplayDetails();
    }
}
