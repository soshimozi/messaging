using Messaging.Shared;
using System.ComponentModel.Composition;
using System.Runtime.Serialization;

namespace Messaging.Messages
{
    [Export(typeof(IMessage))]
    public class EmailMessage : BaseMessage
    {
        public EmailIdentity To { get; set; }

        public EmailIdentity From { get; set; }

        public EmailBodyType BodyType { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }
        public byte[][] Attachments { get; set; }
    }
}
