using System;
class Vehicle{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }
    public Vehicle(int maxspeed, string fueltype){
        MaxSpeed = maxspeed;
        FuelType = fueltype;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine("Max Speed: {0}", FuelType);
        Console.WriteLine("Fuel Type: {0}", FuelType);
    }
}
class Car : Vehicle{
    public int SeatCapacity { get; set; }
    public Car(int maxspeed, string fueltype, int seatcapacity) : base(maxspeed, fueltype){
        SeatCapacity = seatcapacity;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: {0}", SeatCapacity);
    }
}
class Truck : Vehicle{
    public int PayLoadCapacity { get; set; }
    public Truck(int maxspeed, string fueltype, int payloadcapacity) : base(maxspeed, fueltype){
        PayLoadCapacity = payloadcapacity;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Pay Load Capacity: {0}", PayLoadCapacity);
    }
}
class Motorcycle : Vehicle{
    public bool HasSideCar { get; set; }
    public Motorcycle(int maxspeed, string fueltype, bool hassidecar) : base(maxspeed, fueltype){
        HasSideCar = hassidecar;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Has Side Car: {0}", HasSideCar);
    }
}
class Problem3{
    public static void Main(string[]args){
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(21, "Petrol", 3);
        vehicles[1] = new Truck(1120, "Diesel", 10040);
        vehicles[2] = new Motorcycle(1250, "Petrol", true);
       
        foreach (var vehicle in vehicles){
            if (vehicle is Car){
                Console.WriteLine("Car Details: ");
            }
            else if (vehicle is Truck){
                Console.WriteLine("Truck Details: ");
            }
            else if (vehicle is Motorcycle){
                Console.WriteLine("Motorcycle Details: ");
            }
            vehicle.DisplayInfo();
        }
    }
}
