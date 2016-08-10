using System.ServiceModel;
using Messaging.Shared;

namespace Messaging.DispatchServiceLibrary
{
    [ServiceContract]
    public interface IMessageDispatchService
    {
        [OperationContract]
        void SendMessage(BaseMessage message);
    }
}
