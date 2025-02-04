using System;
class Patient{
    // initialising variables
    private static string hospitalName="City Hospital";
    private static int totalPatients=0;
    private string Name,Ailment;
    private int Age;
    private readonly int PatientID;
    // method to get total Patients
    public static void GetTotalPatients(){
        Console.WriteLine("The total number of Patients: {0}", totalPatients);
    }
    public Patient(int PatientID,string Name,int Age,string Ailment){
        this.PatientID=PatientID;
        this.Name=Name;
        this.Age=Age;
        this.Ailment=Ailment;
        totalPatients++;
    }
    // displaying method
    public void DisplayPatientDetails(){
        Console.WriteLine(hospitalName);
        Console.WriteLine("The Patient Id is : {0}", PatientID);
        Console.WriteLine("The Patient Name is : {0} ", Name);
        Console.WriteLine("The age is: {0}",Age);
        Console.WriteLine("The Ailment is : {0}", Ailment);
    }
}
class Program{
    static void Main(string[] args){
        // make the instance
        Patient patient1= new Patient(123,"Jassie",22,"Fever");
        Patient patient2= new Patient(112,"Jennie",40,"Stomach Ache");
        if (patient1 is Patient){
            patient1.DisplayPatientDetails();
        }
        if (patient2 is Patient){
            patient2.DisplayPatientDetails();
        }
        // display total students
        Patient.GetTotalPatients();
    }
}
