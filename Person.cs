namespace ConsoleApp1;

public class Person
{
    private int age;
    private string name;
    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
// copying constructor 
// in copying we send the object as parameter to other constructor
    public Person(Person person)
    {
        age = person.age;
        name = person.name;

    }

    public static void Main(string[] args)
    {
        Person man1 = new Person(21, "James Bond");
        // calling the copy contrcutor with man1 object as parameter
        Person man2 = new Person(man1);
        Console.WriteLine("man 1 name: {0}, age: {1}", man1.name, man1.age);
        Console.WriteLine("man 1 name: {0}, age: {1}", man2.name, man2.age);
    }
}