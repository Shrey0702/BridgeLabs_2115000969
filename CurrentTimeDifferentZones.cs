using System;

class CurrentTimeDifferentZones{
    static void Main(){
        // finding current UTC
        DateTimeOffset now = DateTimeOffset.UtcNow;

        DateTimeOffset gmtTime = now; // no conversion needed for UTC to GMT
		// trying to find IST using findsystemtimezonebyid
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset indianTime = TimeZoneInfo.ConvertTime(now, istZone);
		
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pacificTime = TimeZoneInfo.ConvertTime(now, pstZone);

        // displaying the results
        Console.WriteLine("GMT: " + gmtTime);
        Console.WriteLine("IST: " + indianTime);
        Console.WriteLine("PST: " + pacificTime);
        
    }
}
