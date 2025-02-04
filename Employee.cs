using System;
class Employee
{   //initializing variables
    private static string CompanyName = "Capegemini";
    private string Name;
    private readonly int Id;
    private string Designation;
    private static int  TotalEmployees=0;
	//Method to display total employee
    public static void DisplayTotalEmployees(){
       Console.WriteLine("The Total number of Employees is: {0} ", TotalEmployees);
    }
    internal protected Employee(int id, string name, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        TotalEmployees++;
    }
    //Method to display employee details
    public void DisplayEmployee()
    {
        if(this is Employee)
        {
            Console.WriteLine("The Company name is: {0}", CompanyName);
            Console.WriteLine("The Employee Id is: {0}", Id);
            Console.WriteLine("The Employee Name is :{0}", Name);
            Console.WriteLine("The Employee Designation is: {0}", Designation);
        }
        else
        {
            Console.WriteLine("This is not Employee of {0}", CompanyName);
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
    	//make the instance of class
        Employee emp1 = new Employee(123, "David", "Junior Analyst");
        Employee emp2 = new Employee(011, "Guetta", "Senior Analyst");
        // displaying total number of employees
        Employee.DisplayTotalEmployees();
        // displaying employee details
        emp1.DisplayEmployee();
        emp2.DisplayEmployee();
    }
}
