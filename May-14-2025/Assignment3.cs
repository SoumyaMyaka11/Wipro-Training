using System;

namespace Linq_Project
{
    abstract class TicketBooking
    {
        public abstract void BookTicket();

        public void ShowBookingInfo()
        {
            Console.WriteLine("booking tickets");
        }
    }

    class BusBooking : TicketBooking
    {
        public override void BookTicket()
        {
            Console.WriteLine("booking bus tickets");
        }
    }

    class FlightBooking : TicketBooking
    {
        public override void BookTicket()
        {
            Console.WriteLine("booking flight tickets");
        }
    }

    class Program
    {
        public  static void Main()
        {
            TicketBooking booking;

            booking = new BusBooking();
            booking.ShowBookingInfo();
            booking.BookTicket();

            booking = new FlightBooking();
            booking.ShowBookingInfo();
            booking.BookTicket();
        }
    }
}