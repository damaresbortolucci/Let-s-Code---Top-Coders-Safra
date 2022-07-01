namespace NotificationService
{
    public interface INotificationService
    {
        void Send(string contact, string message);
    }

    public interface ISmsNotificationService : INotificationService
    {

    }

    public interface IEmailNotificationService : INotificationService
    {

    }

    public class NotificationServiceProvider : ISmsNotificationService, IEmailNotificationService
    {
        public void Send(string contact, string message)
        {
            Console.WriteLine("Implementação");
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            ISmsNotificationService smsNotificationService = new NotificationServiceProvider();
            IEmailNotificationService emailNotificationService = new NotificationServiceProvider();

            smsNotificationService.Send("999999", "sms");
            emailNotificationService.Send("email", "email");
        }
    }
}