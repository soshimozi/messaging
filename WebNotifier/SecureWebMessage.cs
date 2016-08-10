using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging.Shared;

namespace WebNotifier
{
    [Export(typeof(IMessage))]
    public class SecureWebMessage : BaseMessage
    {
    }
}
