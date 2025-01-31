using System;

public class Circle{
    // Field (Attribute)
    private double radius;

    // Constructor
    public Circle(double radius){
        this.radius = radius;
    }

    // Method to calculate area
    public double GetArea(){
        return Math.PI * radius * radius;
    }

    // method to calculate circumference
    public double GetCircumference(){
        return 2 * Math.PI * radius;
    }

    // method for displaying details
    public void DisplayDetails(){
        Console.WriteLine("Radius: {0}", radius);
        Console.WriteLine("Area: {0}", GetArea());
        Console.WriteLine("Circumference: {0}", GetCircumference());
    }
}

// Main Class to Test
public class CircleDetails{
    public static void Main(string[] args){
        // creating object
        Circle circle1 = new Circle(5.0);

        // displaying details as depicted in the food delivery example
        Console.WriteLine("=== Circle 1 ===");
        circle1.DisplayDetails();
        
    }
}
