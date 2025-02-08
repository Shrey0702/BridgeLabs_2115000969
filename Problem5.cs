using System;
class Device{
    public int DeviceId { get; set; }
    public string Status { get; set; }
    public Device(int deviceid, string status){
        DeviceId = deviceid;
        Status = status;
    }
    public virtual void DisplayStatus(){
        Console.WriteLine("Device Id: {0}", DeviceId);
        Console.WriteLine("Status: {0}", Status);
    }
}
class Thermostat : Device{
    public int TemperatureSetting { get; set; }
    public Thermostat(int deviceid, string status, int temperaturesetting) : base(deviceid, status){
        TemperatureSetting = temperaturesetting;
    }
    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: {0}", TemperatureSetting);
    }
}
class Problem5{
    public static void Main(string[]args){
        Thermostat thermo = new Thermostat(99, "On", 87);
        thermo.DisplayStatus();
    }
}
