using System;

class StudentGradesCalculatorUsing2DArray{
    public static void Main(){
        // taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // creating a 2D array to store marks
		// finalising rows and columns
        double[,] marks = new double[numStudents, 3];  // 3 subjects for each student
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];  // this will store the grades/remarks for each student

        // taking input for marks in Physics, Chemistry, and Maths
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Enter details for Student {0}: ", i + 1);

            // taking input for Physics marks
            while (true) {
                Console.Write("Enter Physics marks: ");
				// [i, 0] means we are setting the physice marks for the ith students
                marks[i, 0] = double.Parse(Console.ReadLine());
                if (marks[i, 0] >= 0) {
                    break;  // exit the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // taking input for Chemistry marks
            while (true) {
                Console.Write("Enter Chemistry marks: ");
                marks[i, 1] = double.Parse(Console.ReadLine());
                if (marks[i, 1] >= 0) {
                    break;  // exit the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // taking input for Maths marks
            while (true) {
                Console.Write("Enter Maths marks: ");
                marks[i, 2] = double.Parse(Console.ReadLine());
                if (marks[i, 2] >= 0) {
                    break;  // exit the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // calculating percentage
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300) * 100;  // assuming full marks in each subject are 100

            // determining grade based on percentage
            if (percentages[i] >= 80) {
                grades[i] = "Level 4, above agency-normalized standards";
            } 
            else if (percentages[i] >= 70) {
                grades[i] = "Level 3, at agency normalized standards";
            } 
            else if (percentages[i] >= 60) {
                grades[i] = "Level 2, below, but approaching agency-normalized standards";
            } 
            else if (percentages[i] >= 50) {
                grades[i] = "Level 1, well below agency-normalized standards";
            } 
            else if (percentages[i] >= 40) {
                grades[i] = "Level 1, too below agency-normalized standards";
            }
            else {
                grades[i] = "Remedial standards";
            }
        }

        // displaying the marks, percentages, and grades for each student
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Student {0}:", i + 1);
            Console.WriteLine("Physics Marks: {0}", marks[i, 0]);
            Console.WriteLine("Chemistry Marks: {0}", marks[i, 1]);
            Console.WriteLine("Maths Marks: {0}", marks[i, 2]);
            Console.WriteLine("Percentage: {0}", percentages[i]);
            Console.WriteLine("Grade: {0}", grades[i]);
        }
    }
}
