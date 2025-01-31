using System;

class DateArithematic{
    static void Main(){
		// taking user input in yyyy-mm-dd because our DateTime converts the particular format
        Console.Write("enter a date in given format yyyy-mm-dd : ");
        string userInput = Console.ReadLine();

        // converting string to DateTime
        DateTime originalDate = Convert.ToDateTime(userInput);

        // adding 7 days
        DateTime dateAfter7Days = originalDate.AddDays(7);

        // adding 1 month
        DateTime dateAfter1Month = dateAfter7Days.AddMonths(1);

        // adding 2 yrs
        DateTime dateAfter2Years = dateAfter1Month.AddYears(2);

        // subtracting three weeks which is 3 * 7  = 21 days
        DateTime dateAfteSubtracting = dateAfter2Years.AddDays(-21);

        // displaying results
        Console.WriteLine("Original Date: " + originalDate);
        Console.WriteLine("after 7 days: " + dateAfter7Days);
        Console.WriteLine("after 1 month: " + dateAfter1Month);
        Console.WriteLine("after 2 years: " + dateAfter2Years);
        Console.WriteLine("after subtracting 3 weeks: " + dateAfteSubtracting);
        
    }
}
