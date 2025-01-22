using System;
// 1 kg = 2.2 pounds
class PoundsToKg{
    static void PoundsToKgAndPrint(double pounds){
        double kg = pounds / 2.2;  // calculating weight in kilogram
        Console.WriteLine(string.Format("The weight of the person is {0} pounds and {1:F2} kg.", pounds, kg));
    }

    static void Main(){
        Console.Write("Enter the weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        PoundsToKgAndPrint(pounds);
    }
}
