using System;

class LeapYearOrNot{
    static void Main(){
        // taking the year to be checked as input
        Console.Write("enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // checking if the year is allowed
        if (year < 1582){
            Console.WriteLine("invalid year");
            return;
        }

        // checking if the year is a leap year
		// calling the method
        bool isLeapYear = IsLeapYear(year);

        // display the result
		// isLeapYear holds a boolean value which is true if the year is leap
        if (isLeapYear  == true){
            Console.WriteLine("the year {0} is a Leap Year", year);
        }
        else{
            Console.WriteLine("the year {0} is not a Leap Year", year);
        }
    }

  // boolean return type
    public static bool IsLeapYear(int year){
        //  conditions for leap year used && when both needs to be fulfilled and used || when alteast one should be fulfilled
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            return true;
        }
        return false;
    }
}
