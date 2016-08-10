using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using Messaging.Shared;

namespace Messaging.DispatchServiceLibrary
{
    public class MessageDispatcher
    {
        [ImportMany(typeof(IMessageHandler))]
        private IEnumerable<Lazy<IMessageHandler, IExportMessageHandlerMetadata>> Handlers { get; set; }

        public MessageDispatcher(string path = null)
        {
            ManagedExtensionTypeReader.LoadTypes(this, path);
        }

        public void DispatchMessage(object message)
        {
            var query = from h in Handlers
                        where h.Metadata.MessageTypes.Contains(message.GetType())
                        select h;
            
            query.ToList().ForEach(h => h.Value.Handle(message));
        }
    }
}
