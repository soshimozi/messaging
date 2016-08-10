using TestClient.MessageServiceReference;

namespace TestClient
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var client = new MessageDispatchServiceClient("WSHttpBinding_IMessageDispatchService");
            client.SendMessage(new EmailMessage { From = new EmailIdentity { Address = "scott.mccain@gmail.com", FullName = "Scott McCain"}, To = new EmailIdentity {Address = "scott.mccain@gmail.com", FullName = "Scott McCain"}, Subject = "This really will work, trust me!", Body = "Test Test Test"});
            client.SendMessage(new SmsMessage());
            client.SendMessage(new SecureWebMessage());
            client.SendMessage(new WebMessage());
        }
    }
}
