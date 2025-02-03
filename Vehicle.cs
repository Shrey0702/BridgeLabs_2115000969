using System;
class Vehicle
{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 100.0;
	// public constructor
    public Vehicle(string ownerName, string vehicleType)
	{
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }
	// method do siaplay details
    public void DisplayVehicleDetails()
	{
        Console.WriteLine("Owner: {0}, Vehicle: {1}, Registration Fee: {2}", ownerName, vehicleType, registrationFee);
    }
	//updating fees method
    public static void UpdateRegistrationFee(double newFee)
	{
        registrationFee = newFee;
    }
	
	static void Main()
	{
        Vehicle vehicle1 = new Vehicle("David Guetta", "Yatch");
        Vehicle vehicle2 = new Vehicle("Naina", "Motorcycle");

        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(150.0);

        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}

