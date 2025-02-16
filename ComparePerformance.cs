namespace ConsoleApp1;

using System;
using System.Text;
using System.Diagnostics;

class ComparePerformance{
    static void Main(){
        int iteration=100000;
        Stopwatch sw1 =Stopwatch.StartNew();
        string str = "";
        for (int i = 0; i < iteration; i++){
            str += " Performance Test";
        }
        sw1.Stop();
        Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");

        Stopwatch sw2= Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iteration; i++)
        {
            sb.Append(" Performance Test");
        }
        sw2.Stop();
        Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
    }
}


