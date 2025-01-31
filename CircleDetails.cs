using System;

public class Circle{
    private double radius;

    public Circle(double radius){
        this.radius = radius;
    }

    // method to calculate area
    public double Area(){
        return Math.PI * radius * radius;
    }

    // method to calculate circumference
    public double Circumference(){
        return 2 * Math.PI * radius;
    }

    // method for displaying details
    public void DisplayDetails(){
        Console.WriteLine("Radius: {0}", radius);
        Console.WriteLine("Area: {0}", Area());
        Console.WriteLine("Circumference: {0}", Circumference());
    }
}

// Main Class to Test
public class CircleDetails{
    public static void Main(){
        // creating object
        Circle circle1 = new Circle(5.0);

        // displaying details as depicted in the food delivery example
        Console.WriteLine("=== Circle 1 ===");
        circle1.DisplayDetails();
        
    }
}
