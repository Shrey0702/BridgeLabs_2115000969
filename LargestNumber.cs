using System;

class LargestNumber{
    static void CheckingLargestNumber(int number1, int number2, int number3){
		string num1Largest = "No", num2Largest = "No", num3Largest = "No";
		// checking if num 1 is greater than other numbers
        if (number1 > number2 && number1 > number3){
			num1Largest = "Yes"; // updating the values to Yes
        }
		// checking if num 2 is greater than other numbers
        else if (number2 > number1 && number2 > number3){
			num2Largest = "Yes";
        }
		// checking if num 3 is greater than other numbers
        else if (number3 > number1 && number3 > number2){
			num3Largest = "Yes";
        }
        else{  
		// it will check for the edge cases like if two of them are equal or all of them holds the same value
            Console.WriteLine("There is no unique largest number ");
			return; 
			// it will return to the line where the object was called because we don't want to print anything after that
        }
		Console.WriteLine(string.Format("Is the first number the largest? {0}\nIs the second number the largest? {1}\nIs the third number the largest? {2}\n", num1Largest, num2Largest, num3Largest));
    }

    static void Main(){

        // taking input one by one
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        CheckingLargestNumber(number1, number2, number3);
    }
}
