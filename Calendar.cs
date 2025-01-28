using System;

class Calendar
{
    public static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Call the method to display the calendar for the given month and year
        DisplayCalendar(month, year);
    }

    // Method to display the calendar
    public static void DisplayCalendar(int month, int year)
    {
        // Get the name of the month
        string monthName = GetMonthName(month);

        // Get the number of days in the month
        int daysInMonth = GetDaysInMonth(month, year);

        // Get the first day of the month
        int firstDayOfMonth = GetFirstDayOfMonth(month, year);

        // Display the calendar header using string.Format()
        Console.WriteLine(string.Format("\n{0} {1}", monthName, year));
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Print leading spaces based on the first day of the month
        for (int i = 0; i < firstDayOfMonth; i++)
        {
            Console.Write("    "); // 4 spaces for each day before the first day
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            // Print the day with right justification and 3 spaces width using string.Format()
            Console.Write(string.Format("{0,3} ", day));

            // Move to the next line after Saturday
            if ((firstDayOfMonth + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }

    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] monthNames = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        return monthNames[month - 1];
    }

    // Method to get the number of days in the month, considering leap year for February
    public static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth = {
            31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };

        // Check for leap year if the month is February
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }

        return daysInMonth[month - 1];
    }

    // Method to check if the year is a leap year
    public static bool IsLeapYear(int year)
    {
        // Leap year is divisible by 4, but not divisible by 100 unless divisible by 400
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }

    // Method to get the first day of the month using the Gregorian calendar algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        // Apply the Gregorian calendar algorithm
        int y = year;
        int m = month;

        if (m <= 2)
        {
            m += 12;
            y -= 1;
        }

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0;
    }
}
