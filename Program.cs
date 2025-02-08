using System;
class Animal{
	// created protected variables
    protected string Name { get; set; }
    protected int Age { get; set; }
    public Animal(string name, int age){
        Name = name;
        Age = age;
    }
	
	// making parent class method
    public virtual void MakeSound(){
        Console.WriteLine("Animal Make A Sound");
    }
}

// creating derived class
class Dog : Animal{
    public string Breed { get; set; }
    public Dog(string name, int age, string breed) : base(name, age){
        Breed = breed;
    }
	
	// overriding the method for derived class
    public override void MakeSound(){
        Console.WriteLine("Dog Bark");
    }
}

// creating other derived class
class Cat : Animal{
    public string Color { get; set; }
    public Cat(string name, int age, string color) : base(name, age){
        Color = color;
    }
    public override void MakeSound(){
        Console.WriteLine("Cat Meow");
    }
}
class Bird : Animal{
    public string Species { get; set; }
    public Bird(string name, int age, string species) : base(name, age){
        Species = species;
    }
    public override void MakeSound(){
        Console.WriteLine("Bird Chirp");
    }
}
class Program {
    static void Main(string[] args) {
        Animal animal = new Animal("Animal", 1);
        Dog dog = new Dog("Dog", 5, "Golden Retriever");
        Cat cat = new Cat("Cat", 3, "White");
        Bird bird = new Bird("Bird", 2, "Pigeon");
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}
