using System;
class Employee{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int id, double salary){
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayDetails(){
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Id: {0}", Id);
        Console.WriteLine("Salary: {0}", Salary);
    }
}
class Manager : Employee{
    public int TeamSize { get; set; }
    public Manager(string name, int id,double salary,int teamsize) : base(name, id, salary){
        TeamSize = teamsize;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size: {0}");
    }
}
class Developer : Employee{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, int id, double salary, string programminglanguage) : base(name, id, salary){
        ProgrammingLanguage = programminglanguage;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Programming Language: {0}", ProgrammingLanguage);
    }
}
class Intern : Employee{
    public string InternshipDuration { get; set; }
    public Intern(string name, int id, double salary, string internshipduration) : base(name, id, salary){
        InternshipDuration = internshipduration;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: {0}", InternshipDuration);
    }
}
class Problem2{
    static void Main(string[] args) {
        Manager mng = new Manager("Shrey", 132, 77777, 3);
        Developer dev = new Developer("Batman", 102, 40000, "C#");
        Intern intern = new Intern("Charles Leclerc", 103, 23000, "6 months");
        mng.DisplayDetails();
        dev.DisplayDetails();
        intern.DisplayDetails();
    }
}
