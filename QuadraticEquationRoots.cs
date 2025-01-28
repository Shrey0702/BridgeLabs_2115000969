using System;

class QuadraticEquationRoots{
    public static void Main(){
        // taking input
        Console.Write("Enter the coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calling the method to find roots
        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("The roots are: root1 = {0} and root2 = {1}", roots[0], roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The root is: root = {0}", roots[0]);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }

    // method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c){
	// calculating delta
        double delta = Math.Pow(b, 2) - (4 * a * c);

        if (delta > 0){  // means real roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        // if delta =  0, one real root
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root }; // returning one root
        }
		// no real roots
        else{
            return new double[0]; // returning empty array
        }
    }
}
