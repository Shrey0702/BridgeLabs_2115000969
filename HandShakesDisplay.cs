using System;

class HandShakesDisplay{
    static void Main(string[] args){
	// taking user input
        Console.Write("Enter the number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        CalculateAndDisplayHandshakes(students);
    }

    static void CalculateAndDisplayHandshakes(int students)
    {
			// using the formula to calculate handshakes
            int handshakes = (students * (students - 1)) / 2;

            // display the number of possible handshakes
            Console.WriteLine("The maximum number of handshakes among {0} students is {1}", students, handshakes);
    }
}
