using System;

class DateComparision{
    static void Main(){
		// taking user input
        Console.Write("enter the first date in yyyy-mm-dd format: ");
        string input1 = Console.ReadLine();
        
        Console.Write("enter the second date int yyyy-MM-dd format: ");
        string input2 = Console.ReadLine();

		// converting string to date
        DateTime date1 = Convert.ToDateTime(input1);
        DateTime date2 = Convert.ToDateTime(input2);
		// compare method gives positive if first date is after second date
		// negative if second date is after first date, 0 if both the dates are same
		int result = date1.CompareTo(date2);
		// comparing dates
        if (result < 0){
            Console.WriteLine("first date {0} is before the second date {1}", date1, date2);
        }
        else if (result > 0){
            Console.WriteLine("first date {0} is after the second date {1}", date1, date2);        }
        else{
            Console.WriteLine("both dates are same: " + date1);
        }

    }
}
