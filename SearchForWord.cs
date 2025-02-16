namespace ConsoleApp1;

using System;
class SearchForWord{
    static void LinearSearch(string[] arr,string word){
        if(arr.Length==0){
            Console.WriteLine("No element in array");
            return;
        }
        //searching word in sentence
        for(int i=0;i<arr.Length;i++){
            foreach(string words in arr[i].Split()){
                if(words==word){
                    Console.WriteLine($"Word: {word} in Sentence :{arr[i]}");
                    return;
                }}
        }
        Console.WriteLine("Not Found.");
    }
    static void Main(){
        Console.Write("Enter the number of Inputs: ");
        int number=int.Parse(Console.ReadLine());
        string[] arr= new string[number];
        int index=0;
        while(index<number){
            Console.Write("Enter the Sentence: ");
            arr[index]= Console.ReadLine();
            index++;
        }
        Console.WriteLine("Enter the word to found: ");
        //call the method
        LinearSearch(arr,Console.ReadLine());
    }
}

