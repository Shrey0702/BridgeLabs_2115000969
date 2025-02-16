namespace ConsoleApp1;

using System;
using System.IO;
using System.Text;
class ConvertStream{
    static void ReadAndShow(string path){
        try{
            // converting to binary as filestream give output in binary
            using (FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
                //Using encoding to convert binary to char
            using (StreamReader sr= new StreamReader(fs,Encoding.UTF8)){
                string content=sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
    static void Main(){
        string filePath="sample.txt";
        ReadAndShow(filePath);
        
    }
}

