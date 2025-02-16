namespace ConsoleApp1;

using System;
using System.IO;
class OccuranceOfWord{
    static int ReadAndCountWord(string path,string word){
        try{
            using (StreamReader sr= new StreamReader(path)){
                string line;
                int count=0;
                while((line=sr.ReadLine())!=null){
                    foreach(string words in line.Split()){
                        if (words==word){
                            count++;
                        }
                    }
                }
                return count;
            }
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static void Main()
    {
        string filePath = "sample.txt";
        Console.WriteLine("Enter the word to search: ");
        string word = Console.ReadLine();
        int count = ReadAndCountWord(filePath, word);
        Console.WriteLine($"The word {word} count is : {count}");

    }
}

