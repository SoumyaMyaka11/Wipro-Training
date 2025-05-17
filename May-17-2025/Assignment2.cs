using System;

namespace ConsoleApp3
{
    internal interface ISupportTicket
    {
        void CreateTicket(string issue);
        void ResolveTicket(int ticketId);
    }

    class EmailSupport  : ISupportTicket
    { 
        public void CreateTicket(string issue)
        {
            Console.WriteLine($"creating ticket via Email for the issue {issue}");
        }
        public void ResolveTicket(int ticketId)
        {
            Console.WriteLine($"resolving ticket with {ticketId} via Email");
        }
    }

    class PhoneSupport : ISupportTicket
    {
        public void CreateTicket(string issue)
        {
            Console.WriteLine($"creating ticket via Phone for the issue {issue}");
        }
        public void ResolveTicket(int ticketId)
        {
            Console.WriteLine($"resolving ticket with {ticketId} via Phone ");
        }
    }

    class Program
    {
        public static void Main()
        {
            ISupportTicket ticket;

            ticket = new EmailSupport();
            ticket.CreateTicket("ticket has been cancelled even after booking");
            ticket.ResolveTicket(100);

            ticket = new PhoneSupport();
            ticket.CreateTicket("booking has not been confirmed after booking the tickett");
            ticket.ResolveTicket(345);
        }
    }
}
