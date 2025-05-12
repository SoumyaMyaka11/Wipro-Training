using System;

namespace ConsoleApp2
{
    abstract class Notification
    {
        public abstract void Send();

        public  void ShowType()
        {
            Console.WriteLine("Sening Notifications ");
        }
    }

    class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }

    class SMSNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }

    class Program
    {
        static void Main()
        {
            Notification notify;

            notify = new EmailNotification();
            notify.ShowType();
            notify.Send();

            notify = new SMSNotification();
            notify.ShowType();
            notify.Send();
        }
    }
}
