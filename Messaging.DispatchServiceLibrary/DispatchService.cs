using Messaging.Shared;

namespace Messaging.DispatchServiceLibrary
{
    public class DispatchService : IMessageDispatchService
    {
        private readonly MessageDispatcher _dispatcher = new MessageDispatcher(@"C:\Users\Monkey\AppData\Local\Temp\Messages");
        public void SendMessage(BaseMessage message)
        {
            // do some DI to find the handler for the message;
            _dispatcher.DispatchMessage(message);
        }
    }
}
