namespace ConsoleApp1;

public class Employee
{
    private static string companyName = "Capgemini";
    private static int totalEmployees;
    private readonly int employeeId;
    private string name;
    private string designation;

    Employee(int employeeId, string name, string designation)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.designation = designation;
        totalEmployees++;
    }

    public static int DisplayTotalEmployees()
    {
        return totalEmployees;
    }
    
    public static void EmployeeDetails(Employee employee)
    {
        if (employee is Employee)
        {
            Console.WriteLine("employee id: {0}, name: {1}, designation: {2}, in organisation: {3}", employee.employeeId, employee.name, employee.designation, companyName);
        }
        else
        {
            Console.WriteLine("sorry no employee found");
        }
    }
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee(7, "Darwin", "Junior Analyst");
        Employee emp2 = new Employee(77, "Peter", "Senior Analyst");
        EmployeeDetails(emp1);
        EmployeeDetails(emp2);
        Console.WriteLine("Total Employees: {0}", totalEmployees);
    }
}