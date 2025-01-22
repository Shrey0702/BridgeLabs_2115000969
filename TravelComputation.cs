using System;

class TravelComputation
{
    public static void ComputeTravelDetails(string name, string fromCity, string viaCity, string toCity, double distanceFromToVia, double distanceViaToFinalCity, int timeFromToVia, int timeViaToFinalCity)
    {
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;

        Console.WriteLine(string.Format("The results of the trip are: {0} traveled from {1} to {2} via {3}, total distance: {4} miles, total time: {5} hours and {6} minutes.", 
                                        name, fromCity, toCity, viaCity, totalDistance, totalTime / 60, totalTime % 60));
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the name of the traveler: ");
        string name = Console.ReadLine();

        Console.Write("Enter the name of the city you are traveling from: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the name of the city you are traveling via: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the name of the city you are traveling to: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from {0} to {1} (in miles): ", fromCity, viaCity);
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from {0} to {1} (in miles): ", viaCity, toCity);
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken from {0} to {1} (hours): ", fromCity, viaCity);
        int timeFromToViaHours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the time taken from {0} to {1} (minutes): ", fromCity, viaCity);
        int timeFromToViaMinutes = Convert.ToInt32(Console.ReadLine());
        int timeFromToVia = timeFromToViaHours * 60 + timeFromToViaMinutes;

        Console.Write("Enter the time taken from {0} to {1} (hours): ", viaCity, toCity);
        int timeViaToFinalCityHours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the time taken from {0} to {1} (minutes): ", viaCity, toCity);
        int timeViaToFinalCityMinutes = Convert.ToInt32(Console.ReadLine());
        int timeViaToFinalCity = timeViaToFinalCityHours * 60 + timeViaToFinalCityMinutes;

        ComputeTravelDetails(name, fromCity, viaCity, toCity, 
                             distanceFromToVia, distanceViaToFinalCity, 
                             timeFromToVia, timeViaToFinalCity);
    }
}
