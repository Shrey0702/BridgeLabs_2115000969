using System;
namespace VehicleRegisitrationSystem{
    class Vehicle{
        // tnitialize variables
        private string OwnerName;
        private string VehicleType;
        private readonly string RegistrationNumber;
        private static int RegistrationFee=10000;
        // method to update Registration fees
        public static void UpdateRegistrationFee(int fees){
            RegistrationFee=fees;
        }
        public Vehicle(string OwnerName,string VehicleType,string RegistrationNumber){
            this.OwnerName=OwnerName;
            this.VehicleType=VehicleType;
            this.RegistrationNumber=RegistrationNumber;
        }
        // method to display details
        public void DisplayVehicleDetails(){
            Console.WriteLine("The Owner is : {0}", OwnerName);
            Console.WriteLine("The VehicleType is : {0}", VehicleType);
            Console.WriteLine("The Registration Number: {0}", RegistrationNumber);
            Console.WriteLine("The Registration Fees is : {0}", RegistrationFee);
        }

    }
    class Program{
        static void Main(string[] args){
            // make the instance
            Vehicle veh1= new Vehicle("Shrey Bhardwaj","SUV","UP81AWXXXX");
            Vehicle.UpdateRegistrationFee(15000);
            Vehicle veh2 = new Vehicle("Lakshay","Luxury","DL1BACXXXX");
            // check the object
            if(veh1 is Vehicle){
                veh1.DisplayVehicleDetails();
            }
            if (veh2 is Vehicle){
                veh2.DisplayVehicleDetails();
            }

        }
    }
}
