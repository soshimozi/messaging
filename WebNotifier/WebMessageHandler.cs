using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging.Shared;

namespace WebNotifier
{
    [ExportMessageHandler(MessageTypes = new[] { typeof(WebMessage), typeof(SecureWebMessage) })]
    public class WebMessageHandler : IMessageHandler
    {
        private static void HandleSecureWebMessage(SecureWebMessage message)
        {
            
        }

        private static void HandleWebMessage(WebMessage message)
        {
            
        }

        public void Handle(object message)
        {
            var secureWebMessage = message as SecureWebMessage;
            if (secureWebMessage != null)
            {
                HandleSecureWebMessage(secureWebMessage);
            } else
            {
                var webMessage = message as WebMessage;
                HandleWebMessage(webMessage);
            }
        }
    }
}
