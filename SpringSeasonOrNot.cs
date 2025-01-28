using System;

class SpringSeasonOrNot{
    static void SpringSeason(int month, int day){
	// here we checked for the spring season
	// days vary in every month so we used another check to see if the day is valid or not
	// we used OR operator to see if atleast one of the following condition is satisfied or not
        if ((month == 3 && day >= 20 && day <= 31) ||(month == 4 && day >= 1 && day <= 30) ||  
            (month == 5 && day >= 1 && day <= 31) || (month == 6 && day >= 1 && day <= 20)) {
            Console.WriteLine("It's a Spring Season");
        }
        else{
            Console.WriteLine("Not a Spring Season");
        }
    }

    static void Main(){
        Console.Write("Enter the month in numbers(1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day of the month: ");
        int day = int.Parse(Console.ReadLine());

        SpringSeason(month, day);
    }
}
