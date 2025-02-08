using System;
class Person{
    public string Name { get; set; }
    public int Id { get; set; }
    public Person(string name, int id){
        Name = name;
        Id = id;
    }
    public virtual void Display(){
        Console.WriteLine($"Name: {Name}, Id: {Id}");
    }
}
interface Worker{
    void PlatformDuties();
}
class Chef : Person, Worker{
    public Chef(string name, int id) : base(name, id){}
    public void PlatformDuties(){
        Console.WriteLine("Cooking");
    }
    public override void Display(){
        Console.WriteLine($"Chef: Name: {Name}, Id: {Id}");
    }
}
class Waiter : Person, Worker{
    public Waiter(string name, int id) : base(name, id){}
    public void PlatformDuties(){
        Console.WriteLine("Serving");
    }
    public override void Display(){
        Console.WriteLine($"Waiter: Name: {Name}, Id: {Id}");
    }
}
class Problem10{
    public static void Main(string[] args){
        Chef chef = new Chef("Mogambo", 1);
        Waiter waiter = new Waiter("ABC", 2);
        chef.Display();
        chef.PlatformDuties();
        waiter.Display();
        waiter.PlatformDuties();
    }
}
