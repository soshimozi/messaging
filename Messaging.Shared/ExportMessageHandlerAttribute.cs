using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Shared
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportMessageHandlerAttribute : ExportAttribute
    {
        //Pass the contract type to the base 
        public ExportMessageHandlerAttribute()
            : base(typeof(IMessageHandler))
        {
            
        } 
        
        //Additional metadata info 
        public Type[] MessageTypes { get; set; }
    }

}
