using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Messaging.Shared
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public class BaseMessage : IMessage
    {
        public static Type[] GetKnownTypes()
        {
            var result = MessageTypeCollector.Instance.Messages.Select(msg => msg.GetType()).ToArray();
            return result;
        }
    }
}
