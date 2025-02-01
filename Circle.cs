namespace ConsoleApp1;

public class Circle
{
    private double radius;

    public Circle() : this(0.0)
    {
        Console.WriteLine("Circle Constructor without parameters ");
    }
// in chaining our above constructor is calling the below constructor with the default value we choose for radius
    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("circle constructor called both the times when we used chaining as well as when we called it directly");
    }

    public static void Main(string[] args)
    {
        // calling constructor for default value
        Circle circle1 = new Circle();
        // calling constructor with parameter 
        Circle circle2 = new Circle(777);
        Console.WriteLine(circle1.radius);
        Console.WriteLine(circle2.radius);
    }
    
    
}