namespace DefaultNamespace;

using System;
using System.Collections.Generic;
// abstract class
abstract class CourseType{
    public string Name{get;set;}
    public int Credits{get;set;}
    public CourseType(string name,int credits){
        Name=name;
        Credits=credits;
    }
    //abstract method
    public abstract void Display();
}
class ExamCourse:CourseType{
    public double  PassingMarks{get;set;}
    public ExamCourse(string name,int credits,double marks):base(name,credits){
        PassingMarks=marks;
    }
    public override void Display(){
        Console.WriteLine($"Course Name: {Name}, Credits: {Credits}, Passing Marks : {PassingMarks}");
    }
}
class AssignmentCourse:CourseType{
     public int NumberOfAssignments{get;set;}
    public AssignmentCourse(string name,int credits,int assignments):base(name,credits){
        NumberOfAssignments=assignments;
    }
    public override void Display(){
        Console.WriteLine($"Course Name: {Name}, Credits: {Credits},Number of Assignments: {NumberOfAssignments}");
    }
}
// generic class
class Course<T> where T:CourseType{
    List<T> courses=new List<T>();
    public void AddCourse(T course){
        courses.Add(course);
    }
    public void Display(){
        foreach(var course in courses){
            course.Display();
        }
        Console.WriteLine();
    }
}
class UniversityManagement{
    static void Main(string[] args){
        ExamCourse course1= new ExamCourse("Btech" 180,400);
        ExamCourse course2= new ExamCourse("MCA", 120,350);

        AssignmentCourse course3= new AssignmentCourse("C# Basic",55,39);
        AssignmentCourse course4= new AssignmentCourse("Game Development using C# abd Unity",25,20);
        Course<ExamCourse> examCourses= new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourses= new Course<AssignmentCourse>();
        examCourses.AddCourse(course1);
        examCourses.AddCourse(course2);
        // cannot add other type of courses in other list
        // examCourses.AddCourse(course3);
        assignmentCourses.AddCourse(course3);
        assignmentCourses.AddCourse(course4);
        examCourses.Display();
        assignmentCourses.Display();

    }
}

