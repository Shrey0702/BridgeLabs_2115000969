using System;
public class Student{
    public int rollNumber;
    protected string name;
    private double CGPA;
    // parameterized constructor
    public Student(int rollNumber, string name, double CGPA)
	{
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }
    // public methods to access and modify CGPA
    public double GetCGPA()
	{
        return CGPA;
    }
    public void SetCGPA(double CGPA)
	{
        this.CGPA = CGPA;
    }
}
// inheriting a class
public class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA) { }

    public void DisplayName()
	{
    	 // Accessing protected member
        Console.WriteLine("Name: " + name);
    }
	
	static void Main(string[] args)
	{
        PostgraduateStudent student = new PostgraduateStudent(199, "Shrey Bhardwaj", 7.9);
        student.DisplayName();
        Console.WriteLine("CGPA: " + student.GetCGPA());
    }
}


