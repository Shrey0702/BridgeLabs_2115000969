using System;

class StudentGradesCalculator {
    public static void Main() {
        // taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // creating arrays to store marks, percentages, and grades
        double[] physicsMarks = new double[numStudents];
        double[] chemistryMarks = new double[numStudents];
        double[] mathsMarks = new double[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];  // this should be string to store the remarks

        // taking input for marks in Physics, Chemistry, and Maths
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Enter details for Student {0}: ", i + 1);

            // taking input for Physics marks
            while (true) {  // using loop so that no invalid marks will be added to the report
                Console.Write("Enter Physics marks: ");
                physicsMarks[i] = double.Parse(Console.ReadLine());
                if (physicsMarks[i] >= 0) {
                    break; // exiting the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // taking input for Chemistry marks
            while (true) {
                Console.Write("Enter Chemistry marks: ");
                chemistryMarks[i] = double.Parse(Console.ReadLine());
                if (chemistryMarks[i] >= 0) {
                    break; // exit the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // taking input for Maths marks
            while (true) {
                Console.Write("Enter Maths marks: ");
                mathsMarks[i] = double.Parse(Console.ReadLine());
                if (mathsMarks[i] >= 0) {
                    break; // exit the loop if marks are valid
                } else {
                    Console.WriteLine("Marks must be a positive value");
                }
            }

            // calculating percentage
            double totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
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
			else if(percentages[i] >= 40){
                grades[i] = "Level 1, too below agency-normalized standars";
            }
			else{
				grades[i] = "Remedial standards";
			}
        }

        // displaying the marks, percentages, and grades for each student
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Student {0}:", i + 1);
            Console.WriteLine("Physics Marks: {0}", physicsMarks[i]);
            Console.WriteLine("Chemistry Marks: {0}", chemistryMarks[i]);
            Console.WriteLine("Maths Marks: {0}", mathsMarks[i]);
            Console.WriteLine("Percentage: {0}", percentages[i]);
            Console.WriteLine("Grade: {0}", grades[i]);
        }
    }
}
