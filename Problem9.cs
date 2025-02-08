using System;
class Person{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
    public virtual void DisplayRole(){
        Console.WriteLine("Role: Person");
    }
}
class Teacher : Person{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject) : base(name, age){
        Subject = subject;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Subject: {Subject}\n");
    }
    public override void DisplayRole(){
        Console.WriteLine("Role: Teacher");
    }
}
class Student : Person{
    public int Grade { get; set; }
    public Student(string name, int age, int grade) : base(name, age){
        Grade = grade;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Grade: {Grade}\n");
    }
    public override void DisplayRole(){
        Console.WriteLine("Role: Student");
    }
}
class Staff : Person{
    public string Department { get; set; }
    public Staff(string name, int age, string department) : base(name, age){
        Department = department;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Department: {Department}\n");
    }
    public override void DisplayRole(){
        Console.WriteLine("Role: Staff");
    }
}
class Problem9{
    public static void Main(string[] args){
        Teacher teacher = new Teacher("Dr. XYZ", 35, "Math");
        Student student = new Student("Karan Gupta", 15, 10);
        Staff staff = new Staff("Ms. ABC", 25, "Management");
        Person[] people = new Person[3];
        people[0] = teacher;
        people[1] = student;
        people[2] = staff;
        foreach(Person person in people){
            person.DisplayRole();
            person.DisplayInfo();
        }
    }
}
