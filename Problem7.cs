using System;
class Course{
    public string CourseName { get; set; }
    public int CourseDuration { get; set; }
    public Course(string coursename, int courseduration){
        CourseName = coursename;
        CourseDuration = courseduration;
    }
    public virtual void DisplayCourseInfo(){
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Course Duration: {CourseDuration}");
    }
}
class OnlineCourse : Course{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }
    public OnlineCourse(string coursename, int courseduration, string platform, bool isrecorded) : base(coursename, courseduration){
        Platform = platform;
        IsRecorded = isrecorded;
    }
    public override void DisplayCourseInfo(){
        base.DisplayCourseInfo();
        Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}
class PaidOnlineCourse : OnlineCourse{
    public double Fee { get; set; }
    public double Discount { get; set; }
    public PaidOnlineCourse(string coursename, int courseduration, string platform, bool isrecorded, double fee, double discount) : base(coursename, courseduration, platform, isrecorded){
        Fee = fee;
        Discount = discount;
    }
    public double DiscountFee(){
        return Fee - (Fee * Discount / 100);
    }
    public override void DisplayCourseInfo(){
        base.DisplayCourseInfo();
        Console.WriteLine($"Fee: {Fee:C}, Discount: {Discount}%, Final Price: {DiscountFee():C}");
    }
}
class Problem7{
    public static void Main(){
        Console.WriteLine("Course:");
        Course c = new Course("Programming", 30);
        c.DisplayCourseInfo();
        Console.WriteLine("\nOnline Course:");
        OnlineCourse oc = new OnlineCourse("Web Development", 40, "Udemy", true);
        oc.DisplayCourseInfo();
        Console.WriteLine("\nPaid Online Course:");
        PaidOnlineCourse poc = new PaidOnlineCourse("Advanced C#", 50, "Coursera", true, 1000, 20);
        poc.DisplayCourseInfo();
    }
} 
