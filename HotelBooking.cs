namespace ConsoleApp1;

public class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;
    // default constructor
    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "suite";
        nights = 1;
    }
    
    // parameterized constructor

    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking booking)
    {
        guestName = booking.guestName;
        roomType = booking.roomType;
        nights = booking.nights;
    }

    public static void Main(string[] args)
    {
        // calling default constrcutor
        HotelBooking booking1 = new HotelBooking();
        // calling parameterized constrcutor
        HotelBooking booking2 = new HotelBooking("Jon Snow", "Deluxe", 07);
        // calling copy constrcutor for default as well as parameterized constrcutor
        HotelBooking booking3 = new HotelBooking(booking1);
        HotelBooking booking4 = new HotelBooking(booking2);
        Console.WriteLine("guest name: {0}, room type: {1} and number of nights: {2}", booking1.guestName, booking1.roomType, booking1.nights);
        Console.WriteLine("guest name: {0}, room type: {1} and number of nights: {2}", booking2.guestName, booking2.roomType, booking2.nights);
        Console.WriteLine("guest name: {0}, room type: {1} and number of nights: {2}", booking3.guestName, booking3.roomType, booking3.nights);
        Console.WriteLine("guest name: {0}, room type: {1} and number of nights: {2}", booking4.guestName, booking4.roomType, booking4.nights);

    }
}