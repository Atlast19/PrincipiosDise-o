// See https://aka.ms/new-console-template for more information

namespace SRP 
{
    class program 
    {
        public static void Main(string[] args) 
        {
        }

        public class EmailNotification
        {
            public void SendEmail(string email, string message)
            {
                Console.WriteLine($"Sending Email to {email}: {message}");
            }

        }

        public class PhoneNotification 
        { 
            public void SendSMS(string PhoneNumber, string message)
            {
                Console.WriteLine($"Sending SMS to {PhoneNumber}: {message}");
            }
        }

        public class NotificationLog 
        {
            public void Lognotification(string message)
            {
                Console.WriteLine($"Logging notification: {message}");
            }
        }
        
    }
}
