namespace ConsoleApp2;

using System;

class Ticket{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime){
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

class TicketReservation{
    private Ticket head;
    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime){
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
        if (head == null){
            head = newTicket;
            head.Next = head; 
            return;
        }
        Ticket temp = head;
        while(temp.Next != head){
            temp = temp.Next;
        }
        temp.Next = newTicket;
        newTicket.Next = head;
    }

    public void RemoveTicket(int ticketID){
        if(head == null){
            Console.WriteLine("No tickets booked");
            return;
        }

        Ticket temp = head, prev = null;

        if(head.TicketID == ticketID && head.Next == head){
            head = null;
            Console.WriteLine("Ticket " + ticketID + " canceled successfully.");
            return;
        }

        do{
            if(temp.TicketID == ticketID){
                if(prev!= null){
                    prev.Next = temp.Next;
                    if(temp == head)
                        head = temp.Next;
                }
                else{
                    Ticket last = head;
                    while (last.Next != head){
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }
                Console.WriteLine("Ticket " + ticketID + " canceled successfully.");
                return;
            }
            prev= temp;
            temp= temp.Next;
        } while(temp != head);

        Console.WriteLine("Ticket not found.");
    }

    public void DisplayTickets(){
        if(head == null){
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = head;
        do{
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Booking Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    public Ticket SearchByCustomerName(string customerName){
        if (head == null)
            return null;

        Ticket temp = head;
        do{
            if (temp.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                return temp;
            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public Ticket SearchByMovieName(string movieName){
        if (head == null)
            return null;

        Ticket temp = head;
        do{
            if (temp.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                return temp;
            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public int CountTotalTickets(){
        if (head == null)
            return 0;

        int count = 0;
        Ticket temp = head;
        do{
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }
}

class OnlineTicketReservationSystem{
    public static void Main(string[] args){
        TicketReservation reservation = new TicketReservation();
        reservation.AddTicket(101, "Shrey", "Clouds", 7, DateTime.Now);
        reservation.AddTicket(102, "Sanchit", "Pacific Rim", 45, DateTime.Now);
        reservation.AddTicket(103, "Ujjawal", "Avengers Doomsday", 17, DateTime.Now);
        reservation.AddTicket(104, "Yash", "Bakirao Mastani", 26, DateTime.Now);

        Console.WriteLine("Current Booked Tickets");
        reservation.DisplayTickets();

        Console.WriteLine("Searching for Ticket by Customer Name Vidya");
        Ticket foundCustomer = reservation.SearchByCustomerName("Bob");
        if (foundCustomer != null)
            Console.WriteLine("Found Ticket ID " + foundCustomer.TicketID + " for " + foundCustomer.CustomerName);
        else
            Console.WriteLine("Ticket not found");

        Console.WriteLine("Searching for Ticket by Movie Name Sultan");
        Ticket foundMovie = reservation.SearchByMovieName("Sultan");
        if (foundMovie != null)
            Console.WriteLine("Found Ticket ID " + foundMovie.TicketID + " for Movie: " + foundMovie.MovieName);
        else
            Console.WriteLine("No tickets found ");

        Console.WriteLine("Total Booked Tickets " + reservation.CountTotalTickets());

        Console.WriteLine("Canceling Ticket ID 102");
        reservation.RemoveTicket(102);

        Console.WriteLine("Updated Booked Tickets");
        reservation.DisplayTickets();
    }
}
