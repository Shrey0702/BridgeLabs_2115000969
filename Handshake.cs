using System;

class Handshake{
    static void CalculateHandshakes(int numberOfStudents)
    {
        // Calculating maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The maximum number of possible handshakes among {0} students is {1}.", numberOfStudents, handshakes);
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        CalculateHandshakes(numberOfStudents);
    }
}
