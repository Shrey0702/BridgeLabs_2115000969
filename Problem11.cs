using System;
class Vehicle{
    public int MaxSpeed {get; set;}
    public string Model {get; set;}
    public Vehicle(int maxspeed, string model){
        MaxSpeed = maxspeed;
        Model = model;
    }
    public virtual void DisplayVehicleInfo(){
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"MaxSpeed: {MaxSpeed}");
    }
}
interface Refuelable{
    void Refuel();
}
class PetrolVehicle : Vehicle, Refuelable{
    public int TankCapacity {get; set;}
    public PetrolVehicle(int maxspeed, string model, int tankcapacity) : base(maxspeed, model){
        TankCapacity = tankcapacity;
    }
    public void Refuel(){
        Console.WriteLine("Refueling...");
    }
    public override void DisplayVehicleInfo(){
        base.DisplayVehicleInfo();
        Console.WriteLine($"TankCapacity: {TankCapacity} liters");
    }
}
class ElectricVehicle : Vehicle{
    public int BatteryCapacity {get; set;}
    public ElectricVehicle(int maxspeed, string model, int batterycapacity) : base(maxspeed,model){
        BatteryCapacity = batterycapacity;
    }
    public void Charge(){
        Console.WriteLine("Charging...");
    }
    public override void DisplayVehicleInfo(){
        base.DisplayVehicleInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}
class Problem11{
    public static void Main(string[] args){
        ElectricVehicle electric = new ElectricVehicle(180, "Tesla Model 3", 75);
        PetrolVehicle petrol = new PetrolVehicle(220, "Skoda", 60);

        Console.WriteLine("Electric Vehicle Details");
        electric.DisplayVehicleInfo();
        electric.Charge();

        Console.WriteLine("Petrol Vehicle Details");
        petrol.DisplayVehicleInfo();
        petrol.Refuel();
    }
}
