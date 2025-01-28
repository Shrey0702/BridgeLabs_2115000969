using System;

class TrigonometricFunctionsCalculator{
    static void Main(){
        // taking user input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());

        // call the method to calculate trigonometric functions
        double[] results = TrigonometricFunctions(angleInDegrees);

        // display the results
        Console.WriteLine("Sine of {0}: {1}", angleInDegrees, results[0]);
        Console.WriteLine("Cosine of {0}: {1}", angleInDegrees, results[1]);
        Console.WriteLine("Tangent of {0}: {1}", angleInDegrees, results[2]);
    }

  
    public static double[] TrigonometricFunctions(double angle){
        // convert angle from degrees to radians
        double angleInRadians = angle * (Math.PI / 180);

        // calculate sine, cosine, and tangent using Math. 
        double sine = Math.Sin(angleInRadians);  // calculates sine for an angle
        double cosine = Math.Cos(angleInRadians);  // calculates cosine for an angle
        double tangent = Math.Tan(angleInRadians);  // calculates tangent for an angle

        // return the results as an array
		// this is how we can return an array froma method
        return new double[] { sine, cosine, tangent };
    }
}
