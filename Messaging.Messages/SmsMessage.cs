using Messaging.Shared;
using System.ComponentModel.Composition;

namespace Messaging.Messages
{
    [Export(typeof(IMessage))]
    public class SmsMessage : BaseMessage
    {
        public string Recipient { get; set; }
    }
}
