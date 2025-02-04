using System;
namespace UniversityStudentManagement{
    class Student{
        //Initialize variables
        private static string UniversityName="GLA University";
        private string Name;
        private readonly int RollNumber;
        private string Grade;
        private static int TotalStudents=0;
        //method to display total number of students
        public static void DisplayTotalStudents(){
            //TotalStudents must be static as it is used inside static method
            Console.WriteLine("The Total number of students: {0}", TotalStudents);
        }
        //Constructor
        public Student(string Name,int RollNumber,string Grade){
            this.Name=Name;
            this.RollNumber=RollNumber;
            this.Grade=Grade;
            TotalStudents++;
        }
        //Method to display student details
        public void DisplayStudentDetails(){
            Console.WriteLine("University name: {0}", UniversityName);
            Console.WriteLine("The student Roll number is :{0}", RollNumber);
            Console.WriteLine("The name of Student: {0}", Name);
            Console.WriteLine("The grade of student is: {0}", Grade);
        }
        //Method to update Grade
        public void UpdateGrade( string newGrade){
            if (this is Student){
                // Only update the grade if the object is an instance of Student
                this.Grade = newGrade;
                Console.WriteLine("Grade updated to {newGrade} for student: {this.Name}");
            }
            else
            {
                Console.WriteLine("The provided object is not a student.");
            }
        }
    }

    class Program{
        static void Main(string[] args){
            //make the instance
            Student student1=new Student("Shrey Bhardwaj",2115000969,"A");
            Student student2= new Student("Laksh Upadhaya",2115500018,"O");
            
            if (student1 is Student){
                student1.UpdateGrade("A+"); 
                student1.DisplayStudentDetails();}

            if (student2 is Student){
            student2.DisplayStudentDetails();}
            Student.DisplayTotalStudents();
         
        }
    }
}
