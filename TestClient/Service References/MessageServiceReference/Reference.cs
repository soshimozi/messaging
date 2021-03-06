﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClient.MessageServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseMessage", Namespace="http://schemas.datacontract.org/2004/07/Messaging.Shared")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestClient.MessageServiceReference.SecureWebMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestClient.MessageServiceReference.WebMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestClient.MessageServiceReference.EmailMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestClient.MessageServiceReference.SmsMessage))]
    public partial class BaseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SecureWebMessage", Namespace="http://schemas.datacontract.org/2004/07/WebNotifier")]
    [System.SerializableAttribute()]
    public partial class SecureWebMessage : TestClient.MessageServiceReference.BaseMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebMessage", Namespace="http://schemas.datacontract.org/2004/07/WebNotifier")]
    [System.SerializableAttribute()]
    public partial class WebMessage : TestClient.MessageServiceReference.BaseMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailMessage", Namespace="http://schemas.datacontract.org/2004/07/Messaging.Messages")]
    [System.SerializableAttribute()]
    public partial class EmailMessage : TestClient.MessageServiceReference.BaseMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[][] AttachmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestClient.MessageServiceReference.EmailBodyType BodyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestClient.MessageServiceReference.EmailIdentity FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestClient.MessageServiceReference.EmailIdentity ToField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[][] Attachments {
            get {
                return this.AttachmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentsField, value) != true)) {
                    this.AttachmentsField = value;
                    this.RaisePropertyChanged("Attachments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestClient.MessageServiceReference.EmailBodyType BodyType {
            get {
                return this.BodyTypeField;
            }
            set {
                if ((this.BodyTypeField.Equals(value) != true)) {
                    this.BodyTypeField = value;
                    this.RaisePropertyChanged("BodyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestClient.MessageServiceReference.EmailIdentity From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestClient.MessageServiceReference.EmailIdentity To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SmsMessage", Namespace="http://schemas.datacontract.org/2004/07/Messaging.Messages")]
    [System.SerializableAttribute()]
    public partial class SmsMessage : TestClient.MessageServiceReference.BaseMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecipientField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recipient {
            get {
                return this.RecipientField;
            }
            set {
                if ((object.ReferenceEquals(this.RecipientField, value) != true)) {
                    this.RecipientField = value;
                    this.RaisePropertyChanged("Recipient");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailIdentity", Namespace="http://schemas.datacontract.org/2004/07/Messaging.Messages")]
    [System.SerializableAttribute()]
    public partial class EmailIdentity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailBodyType", Namespace="http://schemas.datacontract.org/2004/07/Messaging.Messages")]
    public enum EmailBodyType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Plain = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Html = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessageServiceReference.IMessageDispatchService")]
    public interface IMessageDispatchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageDispatchService/SendMessage", ReplyAction="http://tempuri.org/IMessageDispatchService/SendMessageResponse")]
        void SendMessage(TestClient.MessageServiceReference.BaseMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageDispatchService/SendMessage", ReplyAction="http://tempuri.org/IMessageDispatchService/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(TestClient.MessageServiceReference.BaseMessage message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageDispatchServiceChannel : TestClient.MessageServiceReference.IMessageDispatchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageDispatchServiceClient : System.ServiceModel.ClientBase<TestClient.MessageServiceReference.IMessageDispatchService>, TestClient.MessageServiceReference.IMessageDispatchService {
        
        public MessageDispatchServiceClient() {
        }
        
        public MessageDispatchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MessageDispatchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageDispatchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageDispatchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendMessage(TestClient.MessageServiceReference.BaseMessage message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(TestClient.MessageServiceReference.BaseMessage message) {
            return base.Channel.SendMessageAsync(message);
        }
    }
}
