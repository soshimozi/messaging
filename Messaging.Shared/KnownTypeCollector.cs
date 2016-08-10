using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace Messaging.Shared
{
    internal class MessageTypeCollector
    {
        public static MessageTypeCollector Instance
        {
            get;
            private set;
        }

        [ImportMany(typeof(IMessage))]
        public IEnumerable<IMessage> Messages { get; set; }

        static MessageTypeCollector()
        {
            // TODO: get from config or inject somehow
            Instance = new MessageTypeCollector(@"C:\Users\Monkey\AppData\Local\Temp\Messages");
        }

        public MessageTypeCollector(string path = null)
        {
            ManagedExtensionTypeReader.LoadTypes(this, path);
        }

    }
}
