namespace DefaultNamespace;

using System;
using System.Collections.Generic;
// interface IMealPlan
interface IMealPlan{
    public string MealType{get;}
    void Display();
}
// vegetarian class
class Vegetarian:IMealPlan{
    public string MealType=>"Vegetarian";
    public void Display(){
        Console.WriteLine("Eats Vegetable and fruits.");
    }
}
// vegan class
class Vegan:IMealPlan{
    public string MealType=>"Vegan";
    public void Display(){
        Console.WriteLine("Do not consume Dairy Products.");
    }
}
// keto class
class Keto:IMealPlan{
    public string MealType=>"Keto";
    public void Display(){
        Console.WriteLine("Eats less sugar");
    }
}
// high Protein class
class HighProtein:IMealPlan{
    public string MealType=>"High protein";
    public void Display(){
        Console.WriteLine("Eat cereal,fish,oats,protein powder");
    }
}
// generic class
class Meal<T>where T:IMealPlan,new(){
    private T meal;
    public Meal(){
        meal= new T();
    }
    public void GenerateMealPlan(){
        Console.WriteLine($"{meal.MealType} Plan: ");
        meal.Display();
        Console.WriteLine();

    }
}
class Program{
    static void Main(string[] args){
        Meal<Vegetarian> vegetarian= new Meal<Vegetarian>();
        vegetarian.GenerateMealPlan();
        Meal<Vegan> vegan= new Meal<Vegan>();
        vegan.GenerateMealPlan();
        Meal<Keto> keto = new Meal<Keto>();
        keto.GenerateMealPlan();
        Meal<HighProtein> highProtein= new Meal<HighProtein>();
        highProtein.GenerateMealPlan();
    }
}

