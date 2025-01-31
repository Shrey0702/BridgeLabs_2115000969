using System;

class DateFormatting{
    static void Main(){

        // dd/mm/yyyy format
        string format1 = DateTime.Now.ToString("dd/MM/yyyy");

        // yyyy-mm-dd format
		// always remember whenever using write MM instead of mm
        string format2 = DateTime.Now.ToString("yyyy-MM-dd");

        // eee, mmm dd, yyyy format
        string format3 = DateTime.Now.ToString("ddd, MMM dd, yyyy");

        // printing results
        Console.WriteLine("dd/MM/yyyy : {0}", format1);
        Console.WriteLine("yyyy-MM-dd: {0}", format2);
        Console.WriteLine("EEE, MMM dd, yyyy {0}: ", format3);

    }
}
