using System;

namespace Messaging.Shared
{
    public interface IMessageHandler
    {
        void Handle(object message);
    }
}
