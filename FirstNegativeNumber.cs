namespace ConsoleApp1;

using System;
class FirstNegativeNumber{
    static void LinearSearch(int[] arr){
        // if array is empty
        if(arr.Length==0){
            Console.WriteLine("No element in array");
            return;
        }
        // searching for element
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<0){
                Console.WriteLine($"First Negative Number {arr[i]}");
                return;
            }
        }
        // if no negative element present
        Console.WriteLine("No Negative number.");
    }
    static void Main(){
        Console.Write("Enter the number of Inputs: ");
        int number=int.Parse(Console.ReadLine());
        int[] arr= new int[number];
        int index=0;
        while(index<number){
            Console.Write("Enter the number: ");
            arr[index]= int.Parse(Console.ReadLine());
            index++;
        }
        LinearSearch(arr);
    }
}

