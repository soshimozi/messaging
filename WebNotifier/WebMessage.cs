using System.ComponentModel.Composition;
using Messaging.Shared;

namespace WebNotifier
{
    [Export(typeof(IMessage))]
    public class WebMessage : BaseMessage
    {
    }
}
