namespace ConsoleApp1;

public class OnlineCourseManagement
{
    private static string institute; // class variable
    private string courseName;
    private int fee;
    private int duration;
    // used this to instantiate class variable
    static OnlineCourseManagement()
    {
        institute = "GLA University";
    }

    public OnlineCourseManagement(string courseName, int fee, int duration)
    {
        this.courseName = courseName;
        this.fee = fee;
        this.duration = duration;
    }

    public void DisplayCourseDetails()
    {
        // we can call the institute directly without creating an object
        Console.WriteLine("course name: {0}\t course fees: {1}\tduration: {2} Institute: {3}", this.courseName, this.fee, this.duration, institute);
    }

    static void UpdateInstitueName(string newInstitute)
    {
        // modifying the institute name for all objects
        institute = newInstitute;
    }

    public static void Main(string[] args)
    {
        OnlineCourseManagement course1 = new OnlineCourseManagement("B.Tech", 200000, 4);
        OnlineCourseManagement course2 = new OnlineCourseManagement("M.Tech", 150000, 2);
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
        // updating institute name
        UpdateInstitueName("Hogwarts");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}